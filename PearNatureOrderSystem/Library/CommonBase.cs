using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PearNatureOrderSystem.Library
{
    public static class CommonBase
    {
        /// <summary>
        /// 檢查是否重複執行
        /// </summary>
        /// <returns>是/否 T/F</returns>
        public static bool IsProcessing()
        {
            if (Process.GetProcessesByName(Process.GetCurrentProcess().ProcessName).Length > 1) { return true; }
            return false;
        }
        /// <summary>
        /// 取得現在時間(long)
        /// </summary>
        /// <returns></returns>
        public static Int64 GetTimeForInt()
        {
            return Convert.ToInt64(DateTime.Now.ToString("yyyyMMddHHmmssffff"));
        }

        #region MD5

        public static class MD5
        {
            /// <summary>
            /// 建立 SaltKey
            /// </summary>
            /// <returns></returns>
            public static string GenerateKey()
            {
                //DESCryptoServiceProvider desCrypto = (DESCryptoServiceProvider)DESCryptoServiceProvider.Create();
                //return ASCIIEncoding.ASCII.GetString(desCrypto.Key);
                return DateTime.Now.ToShortTimeString();
            }
            /// <summary>
            /// MD5壓密
            /// </summary>
            /// <param name="pToEncrypt">加密內容</param>
            /// <param name="sKey">Salt</param>
            /// <returns></returns>
            public static string MD5Encrypt(string pToEncrypt, string sKey)
            {
                DESCryptoServiceProvider des = new DESCryptoServiceProvider();
                byte[] inputByteArray = Encoding.Default.GetBytes(pToEncrypt);
                des.Key = ASCIIEncoding.ASCII.GetBytes(sKey);
                des.IV = ASCIIEncoding.ASCII.GetBytes(sKey);
                MemoryStream ms = new MemoryStream();
                CryptoStream cs = new CryptoStream(ms, des.CreateEncryptor(), CryptoStreamMode.Write);
                cs.Write(inputByteArray, 0, inputByteArray.Length);
                cs.FlushFinalBlock();
                StringBuilder ret = new StringBuilder();
                foreach (byte b in ms.ToArray())
                {
                    ret.AppendFormat("{0:X2}", b);
                }
                ret.ToString();
                return ret.ToString();
            }

            /// <summary>
            /// MD5解密
            /// </summary>
            /// <param name="pToDecrypt">解密內容</param>
            /// <param name="sKey">Salt</param>
            /// <returns></returns>
            public static string MD5Decrypt(string pToDecrypt, string sKey)
            {
                DESCryptoServiceProvider des = new DESCryptoServiceProvider();

                byte[] inputByteArray = new byte[pToDecrypt.Length / 2];
                for (int x = 0; x < pToDecrypt.Length / 2; x++)
                {
                    int i = (Convert.ToInt32(pToDecrypt.Substring(x * 2, 2), 16));
                    inputByteArray[x] = (byte)i;
                }

                des.Key = ASCIIEncoding.ASCII.GetBytes(sKey);
                des.IV = ASCIIEncoding.ASCII.GetBytes(sKey);
                MemoryStream ms = new MemoryStream();
                CryptoStream cs = new CryptoStream(ms, des.CreateDecryptor(), CryptoStreamMode.Write);
                cs.Write(inputByteArray, 0, inputByteArray.Length);
                cs.FlushFinalBlock();

                StringBuilder ret = new StringBuilder();

                return System.Text.Encoding.Default.GetString(ms.ToArray());
            }
        }

        #endregion
    }
}
