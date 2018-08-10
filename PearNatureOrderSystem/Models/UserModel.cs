using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PearNatureOrderSystem.Models
{
    public class UserModel
    {
        public long Id { get; set; }
        public string Account { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string SaltKey { get; set; }
        public bool isAdmin { get; set; }
    }
    /// <summary>
    /// 儲存使用
    /// </summary>
    public class UserSaveModel
    {
        public long Id { get; set; }
        public string Account { get; set; }
        public string SaltKey { get; set; }
        /// <summary>
        /// 透過字串組合壓密
        /// </summary>
        public string UserModelString { get; set; }

        // TODO 建立壓密規則 Ex. AC|PW|isAdmin => MD5
        // TODO 考慮改為 JWT Token or 單一加密字串
    }
}
