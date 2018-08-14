using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PearNatureOrderSystem.Models;
using static PearNatureOrderSystem.Library.CommonBase;
using System.Windows.Forms;
using System.ComponentModel;
using LiteDB;
using System.Configuration;

namespace PearNatureOrderSystem.Services
{
    public class UserServices
    {
        // TODO 密碼可改用hash做不可逆驗證 => 懶得做
        public delegate void UserChangedEvent();
        public static event UserChangedEvent UserChanged;

        /// <summary>
        /// 建立預設Admin帳號
        /// </summary>
        public static void InitDefaultUser()
        {
            // Create your new users instance
            // 預設帳密資訊
            //string account = "PearNature";
            //string password = "!QAZ2wsx";
            string account = ConfigurationManager.AppSettings["DefaultAdmin"].ToString().Trim();
            string password = "1";
            string name = "Administrator";
            UserModel defaultUser = new UserModel();
            //defaultUser.Id = GetTimeForInt();
            defaultUser.Account = account;
            defaultUser.Password = password;
            defaultUser.Name = name;
            defaultUser.isAdmin = true;
            defaultUser.SaltKey = MD5.GenerateKey();

            using (var db = new LiteDatabase(@"Local.db"))
            {
                // Get customer collection
                var users = db.GetCollection<UserSaveModel>("users");

                var user = users.Find(x => x.Account.ToLower().Trim() == defaultUser.Account.ToLower().Trim()).FirstOrDefault();
                if (user == null)
                {
                    users.Insert(ConvertToSaveModel(defaultUser));
                }
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
            string wwww = $"{userModel.Account}|{userModel.Password}|{userModel.Name}|{userModel.isAdmin}";

            userSaveModel.Id = userModel.Id;
            userSaveModel.SaltKey = userModel.SaltKey;
            userSaveModel.Account = userModel.Account;
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

                userModel.Id = userSaveModel.Id;
                userModel.SaltKey = userSaveModel.SaltKey;

                userModel.Account = sss[0];
                userModel.Password = sss[1];
                userModel.Name = sss[2];
                userModel.isAdmin = Convert.ToBoolean(sss[3]);

                return userModel;
            }
            catch (Exception ex)
            {
                //log here
                return null;
            }
        }
        /// <summary>
        /// 將文檔取回的SaveModel轉回UserModel
        /// </summary>
        /// <param name="userSaveModel"></param>
        /// <returns></returns>
        public static List<UserModel> ConvertToListUserModel(List<UserSaveModel> userSaveModel)
        {
            try
            {
                List<UserModel> userList = new List<UserModel>();
                foreach (var item in userSaveModel)
                {
                    UserModel userModel = new UserModel();
                    string aa = MD5.MD5Decrypt(item.UserModelString, item.SaltKey);
                    string[] sss = aa.Split('|');

                    userModel.Id = item.Id;
                    userModel.SaltKey = item.SaltKey;

                    userModel.Account = sss[0];
                    userModel.Password = sss[1];
                    userModel.Name = sss[2];
                    userModel.isAdmin = Convert.ToBoolean(sss[3]);
                    userList.Add(userModel);
                }

                return userList;
            }
            catch (Exception ex)
            {
                //log here
                return null;
            }
        }

        internal static BindingSource GetUserModelSource()
        {
            var bindingList = new BindingList<UserModel>(GetAllUsers());
            var source = new BindingSource(bindingList, null);
            return source;
        }

        #endregion

        #region BLL Methods
        public static List<UserModel> GetAllUsers()
        {
            List<UserSaveModel> userSaveModels = new List<UserSaveModel>();
            using (var db = new LiteDatabase(@"Local.db"))
            {
                // Get customer collection
                var users = db.GetCollection<UserSaveModel>("users");
                userSaveModels = users.FindAll().ToList();
            }
            return ConvertToListUserModel(userSaveModels);
        }
        /// <summary>
        /// 登入
        /// </summary>
        /// <returns></returns>
        public bool Login(string account, string password)
        {
            using (var db = new LiteDatabase(@"Local.db"))
            {
                // Get customer collection
                var users = db.GetCollection<UserSaveModel>("users");
                var saveUser = users.Find(x => x.Account.ToLower().Trim() == account.ToLower().Trim()).FirstOrDefault();
                var user = ConvertToUserModel(saveUser);
                if (user != null && user.Password.Equals(password.Trim()))
                {
                    Appdata.loginUser = user;
                    return true;
                }
                return false;
            }
        }

        /// <summary>
        /// 檢查帳號是否存在
        /// </summary>
        /// <param name="account"></param>
        /// <returns></returns>
        public bool IsAccountExist(string account)
        {
            var users = GetAllUsers();
            var user = users.FirstOrDefault(x => x.Account.ToLower().Trim() == account.ToLower().Trim());
            if (user != null)
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// 檢查名稱是否存在
        /// </summary>
        /// <param name="account"></param>
        /// <returns></returns>
        public bool IsNameExist(string name)
        {
            var users = GetAllUsers();
            var user = users.FirstOrDefault(x => x.Name == name.Trim());
            if (user != null)
            {
                return true;
            }
            return false;
        }
        #endregion

        #region Create
        /// <summary>
        /// 新增使用者
        /// </summary>
        /// <param name="userModel"></param>
        /// <returns></returns>
        public bool InsertUser(UserModel userModel)
        {
            try
            {
                using (var db = new LiteDatabase(@"Local.db"))
                {
                    // Get customer collection
                    var users = db.GetCollection<UserSaveModel>("users");

                    var user = users.Find(x => x.Account.ToLower().Trim() == userModel.Account.ToLower().Trim()).FirstOrDefault();
                    if (user == null)
                    {
                        users.Insert(ConvertToSaveModel(userModel));
                    }
                }
                UserChanged();
            }
            catch (Exception ex)
            {
                //log here
                return false;
            }
            return true;
        }
        #endregion

        #region Read
        public UserModel QueryUserById(long Id)
        {
            var user = GetAllUsers().FirstOrDefault(x => x.Id == Id);
            return user;
        }
        #endregion

        #region Update
        /// <summary>
        /// 更新使用者
        /// </summary>
        /// <param name="userModel"></param>
        /// <returns></returns>
        public bool UpdateUser(UserModel userModel)
        {
            try
            {
                using (var db = new LiteDatabase(@"Local.db"))
                {
                    var users = db.GetCollection<UserSaveModel>("users");

                    var user = users.Find(x => x.Account.ToLower().Trim() == userModel.Account.ToLower().Trim()).FirstOrDefault();
                    if (user != null)
                    {
                        user = ConvertToSaveModel(userModel);
                        users.Update(user);
                        UserChanged();
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                //log here
                return false;
            }
            return true;
        }
        /// <summary>
        /// 更新使用者
        /// </summary>
        /// <param name="Id"></param>
        /// <param name="account"></param>
        /// <param name="password"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        public bool UpdateUser(long Id, string account, string password, string name)
        {
            try
            {
                using (var db = new LiteDatabase(@"Local.db"))
                {
                    var users = db.GetCollection<UserSaveModel>("users");

                    var user = users.Find(x => x.Account.ToLower().Trim() == account.ToLower().Trim()).FirstOrDefault();
                    if (user != null)
                    {
                        var userModel = ConvertToUserModel(user);
                        //userModel.Account = account; // TODO 確認是否能修改登入帳號
                        userModel.Password = password;
                        userModel.Name = name;

                        user = ConvertToSaveModel(userModel);
                        users.Update(user);
                        UserChanged();
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                //log here
                return false;
            }
            return true;
        }
        #endregion

        #region Delete
        /// <summary>
        /// 刪除使用者
        /// </summary>
        /// <param name="userModel"></param>
        /// <returns></returns>
        public bool DeleteUser(long Id)
        {
            try
            {
                using (var db = new LiteDatabase(@"Local.db"))
                {
                    var users = db.GetCollection<UserSaveModel>("users");

                    var user = users.Find(x => x.Id == Id).FirstOrDefault();
                    if (user != null)
                    {
                        users.Delete(x => x.Id == Id);
                        UserChanged();
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                //log here
                return false;
            }
            return true;
        }

        #endregion
    }
}