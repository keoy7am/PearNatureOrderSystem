using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PearNatureOrderSystem.Models
{
    public class ProductModel
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int MealPrice { get; set; }
        /// <summary>
        /// 餐點備註
        /// </summary>
        public List<ProductRemark> ProductRemarks { get; set; }
        //public long CreatedDateTime { get; set; }
        //public long ModifiedDateTime { get; set; }
    }
}
