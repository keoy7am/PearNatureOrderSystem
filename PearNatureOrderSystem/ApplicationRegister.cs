using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PearNatureOrderSystem.Repository;
using SerializationRepository;

namespace PearNatureOrderSystem
{
    public class ApplicationRegister
    {
        public static RepositoryRegister _categroyRepo { get; set; }
        public static RepositoryRegister _productRepo { get; set; }
        public static RepositoryRegister _userRepo { get; set; }

    }
}
