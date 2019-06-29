using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Printing;
using PearNatureOrderSystem.Models;
using System.IO;
using System.Drawing;
using PearNatureOrderSystem.Services;

namespace PearNatureOrderSystem.Library
{
    public static class PrintHelper
    {
        static string table;
        public static object[] Print(string Table)
        {
            table = Table;
            object[] returnObj = new object[2];
            returnObj[0] = false;
            returnObj[1] = "";
            try
            {
                /* 中文輸出 */
                PrintDocument document = new PrintDocument();
                document.PrintPage += OrderDetail_PrintPage;
                document.DocumentName = "opt";
                document.PrinterSettings.PrinterName = GetDefaultPrinter();
                document.PrintController = new StandardPrintController();
                document.OriginAtMargins = false;
                document.Print();

                PrinterUtility.EscPosEpsonCommands.EscPosEpson obj = new PrinterUtility.EscPosEpsonCommands.EscPosEpson();
                byte[] BytesValue = new byte[100];

                /* Feed Paper And Cut Page */
                //BytesValue = PrinterUtility.PrintExtensions.NewLine(BytesValue, 2);
                BytesValue = PrinterUtility.PrintExtensions.AddBytes(BytesValue, CutPage());
                // TODO 路徑設定方法須實測條碼列印機連線AP後的實際狀況
                PrinterUtility.PrintExtensions.Print(BytesValue, $"{GetDefaultPrinter()}");

                returnObj[0] = true;
            }
            catch(Exception ex)
            {
                returnObj[0] = false;
                returnObj[1] = ex.Message;
            }
            finally
            {
                table = string.Empty;
            }
            return returnObj;
        } 
        private static string StringHandle(string name,string count,string totalPrice)
        {
            return String.Format("{0,-16}{1,-16}{2,-16}", name, count, totalPrice);
        }
        /// <summary>
        /// 輸出條碼列印機裁減指令
        /// </summary>
        /// <returns></returns>
        public static byte[] CutPage()
        {
            List<byte> oby = new List<byte>();
            oby.Add(Convert.ToByte(Convert.ToChar(0x1D)));
            oby.Add(Convert.ToByte('V'));
            oby.Add((byte)66);
            oby.Add((byte)3);
            return oby.ToArray();
        }
        /// <summary>
        /// 取的預設印表機
        /// </summary>
        /// <returns></returns>
        public static string GetDefaultPrinter()
        {
            PrinterSettings settings = new PrinterSettings();
            foreach (string printer in PrinterSettings.InstalledPrinters)
            {
                settings.PrinterName = printer;
                if (settings.IsDefaultPrinter)
                    return printer;
            }
            return string.Empty;
        }
        /// <summary>
        /// 透過繪出字串輸出中文
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private static void OrderDetail_PrintPage(object sender, PrintPageEventArgs e)
        {
            // 測試X座標大概定點
            //e.Graphics.DrawString("_", new Font("微軟正黑體", 14), new SolidBrush(Color.Black), new PointF(0, 10));
            //e.Graphics.DrawString("_", new Font("微軟正黑體", 14), new SolidBrush(Color.Black), new PointF(40, 10));
            //e.Graphics.DrawString("_", new Font("微軟正黑體", 14), new SolidBrush(Color.Black), new PointF(80, 10));
            //e.Graphics.DrawString("_", new Font("微軟正黑體", 14), new SolidBrush(Color.Black), new PointF(120, 10));
            //e.Graphics.DrawString("_", new Font("微軟正黑體", 14), new SolidBrush(Color.Black), new PointF(160, 10));

            // 標頭
            e.Graphics.DrawString("訂單明細", new Font("微軟正黑體", 14), new SolidBrush(Color.Black), new PointF(60, CalcMarginY(0)));
            e.Graphics.DrawString($"桌號：{table}", new Font("微軟正黑體", 12,FontStyle.Bold), new SolidBrush(Color.Black), new PointF(0, CalcMarginY(1)));
            e.Graphics.DrawString("-----------------------------------", new Font("微軟正黑體", 14), new SolidBrush(Color.Black), new PointF(0, CalcMarginY(2)));
            e.Graphics.DrawString(StringHandle("品項", "數量", "金額"), new Font("微軟正黑體", 10), new SolidBrush(Color.Black), new PointF(0, CalcMarginY(3)));
            int startIndex = 4; // 上列標頭行數
            // 繪出訂單內容
            foreach (var item in OrderServices.orderCartDetails)
            {
                e.Graphics.DrawString(item.Name, new Font("微軟正黑體", 9, FontStyle.Bold), new SolidBrush(Color.Black), new PointF(0, CalcMarginY(startIndex)));
                e.Graphics.DrawString(item.Count.ToString(), new Font("微軟正黑體", 9), new SolidBrush(Color.Black), new PointF(100, CalcMarginY(startIndex)));
                e.Graphics.DrawString(item.TotalPrice.ToString(), new Font("微軟正黑體", 9), new SolidBrush(Color.Black), new PointF(150, CalcMarginY(startIndex)));
                startIndex++;
                if (item.ProductRemarks.Count > 0)
                {
                    int rowIndex = 1;
                    string row = "備註：";
                    string tempRow = row;
                    Dictionary<int, string> re = new Dictionary<int, string>();
                    //e.Graphics.DrawString("備註：", new Font("微軟正黑體", 9), new SolidBrush(Color.Black), new PointF(20, CalcMarginY(startIndex)));
                    //startIndex++;
                    int counter = 1;
                    foreach (var remark in item.ProductRemarks)
                    {
                        // 第一個備註時呈現為 備註：少糖 後續為 備註：少糖,少冰,....
                        if (counter == 1)
                        {
                            tempRow = tempRow + remark.Remark;
                        }
                        else
                        {
                            tempRow = tempRow + "," + remark.Remark;
                        }
                        if(Encoding.Default.GetBytes(tempRow).Length > 24)
                        {
                            re.Add(rowIndex, row);
                            row = "";
                            tempRow = row + "," + remark.Remark;
                            rowIndex++;
                        }
                        // 最後一行
                        if(counter == item.ProductRemarks.Count)
                        {
                            re.Add(rowIndex, tempRow);
                            break;
                        }
                        counter++;
                    }
                    for(int i = 1; i <= re.Count; i++)
                    {
                        e.Graphics.DrawString(re.FirstOrDefault(x=>x.Key==i).Value, new Font("微軟正黑體", 9, FontStyle.Bold), new SolidBrush(Color.Black), new PointF(40, CalcMarginY(startIndex)));
                        startIndex++;
                    }
                }
            }
            // 單尾
            e.Graphics.DrawString("-----------------------------------", new Font("微軟正黑體", 14), new SolidBrush(Color.Black), new PointF(0, CalcMarginY(startIndex+1)));
            if (OrderServices.GetTotalPrice() < 1000)
            {
                e.Graphics.DrawString($"總金額 {OrderServices.GetTotalPrice()} 元", new Font("微軟正黑體", 10, FontStyle.Bold), new SolidBrush(Color.Black), new PointF(100, CalcMarginY(startIndex + 2)));
            }
            else
            {
                e.Graphics.DrawString($"總金額 {OrderServices.GetTotalPrice()} 元", new Font("微軟正黑體", 10, FontStyle.Bold), new SolidBrush(Color.Black), new PointF(90, CalcMarginY(startIndex + 2)));
            }
            e.Graphics.DrawString($"印單人 {Appdata.loginUser.Name}", new Font("微軟正黑體", 10), new SolidBrush(Color.Black), new PointF(0, CalcMarginY(startIndex+3)));
            e.Graphics.DrawString($"印單時間 {DateTime.Now.ToString()}", new Font("微軟正黑體", 10), new SolidBrush(Color.Black), new PointF(0, CalcMarginY(startIndex+4)));
            //e.Graphics.DrawString($"Printer: {GetDefaultPrinter()}", new Font("微軟正黑體", 8), new SolidBrush(Color.Black), new PointF(0, CalcMarginY(startIndex+4)));
        }
        /// <summary>
        /// 計算該行數 Y 座標
        /// </summary>
        /// <param name="row">行數</param>
        /// <returns></returns>
        private static int CalcMarginY(int row)
        {
            int iMarginY = 25; //行距
            return iMarginY * row;
        }
    }
}
