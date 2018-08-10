using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PearNatureOrderSystem.Models
{
    public class TableModel
    {
        /// <summary>
        /// Table Id
        /// </summary>
        public long Id { get; set; }
        /// <summary>
        /// 桌號名稱
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 桌號敘述
        /// </summary>
        public string Desc { get; set; }
    }
}
