using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PearNatureOrderSystem.Models
{
    public class OrderModel
    {
        public long Id { get; set; }
        public string OrderOwner { get; set; }
        List<OrderDetailModel> orderDetails { get; set; }
        public long OrderDateTime { get; set; }
    }
    public class OrderDetailModel
    {
        /// <summary>
        /// 識別碼
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 商品名稱
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 數量
        /// </summary>
        public int Count { get; set; }
        /// <summary>
        /// 單價
        /// </summary>
        public int Price { get; set; }
        /// <summary>
        /// 套餐價
        /// </summary>
        public int MealPrice { get; set; }
        /// <summary>
        /// 總金額
        /// </summary>
        public int TotalPrice { get; set; }
        /// <summary>
        /// 是否套餐
        /// </summary>
        public bool isMeal { get; set; }
        /// 是否套餐主食
        /// </summary>
        public bool isMealMaster { get; set; }
        /// <summary>
        /// 餐點備註
        /// </summary>
        public List<ProductRemark> ProductRemarks { get; set; }

    }
}
