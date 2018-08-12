using PearNatureOrderSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        public OrderDetailModel QueryOrderDeatilFromCart(int id)
        {
            return orderCartDetails.FirstOrDefault(x => x.Id == id);
        }
        #endregion
    }
}
