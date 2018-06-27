using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PearNatureOrderSystem.Repository;
using PearNatureOrderSystem.Models;
using static PearNatureOrderSystem.Library.CommonBase;

namespace PearNatureOrderSystem.Services
{
    /// <summary>
    /// For UserSave Model
    /// </summary>
    public class UserServices
    {
        public delegate void UserChangedEvent();
        internal static event UserChangedEvent UserChanged;

        public static UserRepo _userRepo;
        public static void InitUserServices()
        {
            _userRepo = new UserRepo(ApplicationRegister._userRepo);
        }
        /// <summary>
        /// 建立預設Admin帳號
        /// </summary>
        public static void InitDefaultUser()
        {
            var Users = _userRepo.GetAll();
            var user = Users.FirstOrDefault(x => x.Name == "Elliot");
            if (user == null)
            {
                UserModel defaultUser = new UserModel();
                defaultUser.Ident = GetTimeForInt();
                defaultUser.Account = "Elliot";
                defaultUser.Password = "123456";
                defaultUser.Name = "Elliot";
                defaultUser.isAdmin = true;
                defaultUser.SaltKey = MD5.GenerateKey();
                var saveModel = ConvertToSaveModel(defaultUser);
                _userRepo.Add(saveModel);
                _userRepo.Save();
            }
        }
        #region nonBLL Method

        /// <summary>
        /// 將記憶體內的UserModel轉為儲存用的UserSaveModel
        /// </summary>
        /// <param name="userModel"></param>
        /// <returns></returns>
        public static UserSaveModel ConvertToSaveModel(UserModel userModel)
        {
            UserSaveModel userSaveModel = new UserSaveModel();
            string wwww = $"{userModel.Account}|{userModel.Password}|{userModel.isAdmin}";

            userSaveModel.Ident = userModel.Ident;
            userSaveModel.SaltKey = userModel.SaltKey;
            userSaveModel.Name = userModel.Name;
            userSaveModel.UserModelString = MD5.MD5Encrypt(wwww, userSaveModel.SaltKey);

            return userSaveModel;
        }
        /// <summary>
        /// 將文檔取回的SaveModel轉回UserModel
        /// </summary>
        /// <param name="userSaveModel"></param>
        /// <returns></returns>
        public static UserModel ConvertToUserModel(UserSaveModel userSaveModel)
        {
            try
            {
                UserModel userModel = new UserModel();
                string aa = MD5.MD5Decrypt(userSaveModel.UserModelString, userSaveModel.SaltKey);
                string[] sss = aa.Split('|');

                userModel.Ident = userSaveModel.Ident;
                userModel.SaltKey = userSaveModel.SaltKey;
                userModel.Name = userSaveModel.Name;

                userModel.Account = sss[0];
                userModel.Password = sss[1];
                userModel.isAdmin = Convert.ToBoolean(sss[2]);
                
                return userModel;
            }
            catch (Exception ex)
            {
                //log here
                return null;
            }
        }

        #endregion

        #region BLL Methods
        /// <summary>
        /// 登入
        /// </summary>
        /// <returns></returns>
        public bool Login(string account, string password)
        {
            var saveUser = _userRepo.GetAll().FirstOrDefault(x => x.Name.ToUpper() == account.Trim().ToUpper());
            var user = ConvertToUserModel(saveUser);
            if (user != null && user.Password.Equals(password.Trim()))
            {
                Appdata.loginUser = user;
                return true;
            }
            return false;
        }

        #endregion

    }
}