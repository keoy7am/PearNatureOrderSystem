using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PearNatureOrderSystem.Models
{
    public class CategroyModel
    {
        public long Ident { get; set; }
        public string Name { get; set; }
        public List<ProductModel> Products{ get; set; }
        public long CreatedDateTime { get; set; }
        public long ModifiedDateTime { get; set; }
    }
}
