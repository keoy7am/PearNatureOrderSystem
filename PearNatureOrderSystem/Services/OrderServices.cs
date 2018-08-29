using LiteDB;
using PearNatureOrderSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PearNatureOrderSystem.Services
{
    public class OrderServices
    {
        public delegate void OrderCartChangedEvent();
        public static event OrderCartChangedEvent OrderCartChanged;
        public delegate void ProductRemarkChangedEvent();
        public static event ProductRemarkChangedEvent ProductRemarkChanged;

        public static List<OrderDetailModel> orderCartDetails = new List<OrderDetailModel>();
        public static int idCounter = 0;

        #region OrderCart
        #region BindingSource
        public static BindingSource GetOrderCartSource()
        {
            var bindingList = new BindingList<OrderDetailModel>(orderCartDetails);
            var source = new BindingSource(bindingList, null);
            return source;
        }
        #endregion
        public static void ResetOrderCart()
        {
            orderCartDetails = new List<OrderDetailModel>();
            idCounter = 0;
            OrderCartChanged();
        }
        public static int GetTotalPrice()
        {
            int totalPrice = 0;
            foreach (var item in orderCartDetails)
            {
                totalPrice += item.TotalPrice;
            }
            return totalPrice;
        }
        public void AddToCart(OrderDetailModel orderDetail)
        {
            orderDetail.Id = idCounter;
            orderCartDetails.Add(orderDetail);
            idCounter++;
            OrderCartChanged();
        }
        public void UpdateToCart(OrderDetailModel orderDetail)
        {
            var query = orderCartDetails.FirstOrDefault(x => x.Id == orderDetail.Id);
            query = orderDetail;
        }
        public void RemoveFromCart(OrderDetailModel orderDetail)
        {
            var query = orderCartDetails.FirstOrDefault(x => x.Id == orderDetail.Id);
            orderCartDetails.Remove(query);
            OrderCartChanged();
        }
        public static void RemoveFromCart(int id)
        {
            var query = orderCartDetails.FirstOrDefault(x => x.Id == id);
            orderCartDetails.Remove(query);
            OrderCartChanged();
        }
        public OrderDetailModel QueryOrderDeatilFromCart(int id)
        {
            return orderCartDetails.FirstOrDefault(x => x.Id == id);
        }
        #endregion



        #region Misc
        public static List<ProductRemark> GetAllRemarks()
        {
            List<ProductRemark> remark = new List<ProductRemark>();
            using (var db = new LiteDatabase(ConfigurationManager.AppSettings["DBName"].ToString().Trim()))
            {
                // Get customer collection
                var remarks = db.GetCollection<ProductRemark>("prodRemark");
                remark = remarks.FindAll().ToList();
            }
            return remark;
        }
        #endregion
        #region Create
        public bool InsertRemark(ProductRemark productRemark)
        {
            try
            {
                using (var db = new LiteDatabase(ConfigurationManager.AppSettings["DBName"].ToString().Trim()))
                {
                    var remarks = db.GetCollection<ProductRemark>("prodRemark");
                    var remark = remarks.Find(x => x.Id == productRemark.Id).FirstOrDefault();

                    if (remark == null)
                    {
                        remarks.Insert(productRemark);
                        ProductRemarkChanged();
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                // log here
                return false;
            }
        }
        #endregion
        #region Read
        public ProductRemark QueryRemarkById(int id)
        {
            ProductRemark productRemark;

            using (var db = new LiteDatabase(ConfigurationManager.AppSettings["DBName"].ToString().Trim()))
            {
                // Get customer collection
                var remarks = db.GetCollection<ProductRemark>("prodRemark");
                var remark = remarks.Find(x => x.Id == id).FirstOrDefault();
                productRemark = remark;
            }
            return productRemark;
        }
        #endregion
        #region Update
        public bool UpdateRemark(ProductRemark productRemark)
        {
            try
            {
                using (var db = new LiteDatabase(ConfigurationManager.AppSettings["DBName"].ToString().Trim()))
                {
                    var remarks = db.GetCollection<ProductRemark>("prodRemark");
                    var remark = remarks.Find(x => x.Id == productRemark.Id).FirstOrDefault();

                    if (remark != null)
                    {
                        remark = productRemark;
                        remarks.Update(remark);
                        ProductRemarkChanged();
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                return false;
                // log here
            }
            return true;
        }
        #endregion
        #region Delete
        public bool DeleteRemark(long id)
        {
            try
            {
                using (var db = new LiteDatabase(ConfigurationManager.AppSettings["DBName"].ToString().Trim()))
                {
                    var remarks = db.GetCollection<ProductRemark>("prodRemark");

                    var remark = remarks.Find(x => x.Id == id).FirstOrDefault();
                    if (remark != null)
                    {
                        remarks.Delete(x => x.Id == id);
                        ProductRemarkChanged();
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                //log here
                return false;
            }
            return true;
        }
        #endregion
    }
}
