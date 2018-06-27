using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PearNatureOrderSystem.Models
{
    public class ProductModel
    {
        public long Ident { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public long CreatedDateTime { get; set; }
        public long ModifiedDateTime { get; set; }
    }
}
