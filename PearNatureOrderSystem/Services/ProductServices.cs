using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PearNatureOrderSystem.Repository;

namespace PearNatureOrderSystem.Services
{
    public class ProductServices
    {
        public static CategroyRepo _categroyRepo;
        public static ProductRepo _productRepo;
        public static void InitProductSerices()
        {
            _categroyRepo = new CategroyRepo(ApplicationRegister._categroyRepo);
            _productRepo = new ProductRepo(ApplicationRegister._productRepo);
        }

        #region BLL Method

        #endregion
    }
}
