using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SerializationRepository;
using SerializationRepository.Repositories;
using PearNatureOrderSystem.Models;

namespace PearNatureOrderSystem.Repository
{
    public class UserRepo : RepositoryBase<UserSaveModel>
    {
        public UserRepo(RepositoryRegister repositoryRegister) : base(repositoryRegister)
        {

        }

        /// <summary>
        /// 依照iden Id 取值
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public override UserSaveModel GetSingle(long id)
        {
            var found = _dataList.FirstOrDefault(x => x.Ident == id);
            return found;
        }

        /// <summary>
        /// 依照iden Id更新值
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public override void Update(long id, UserSaveModel data)
        {
            var found = _dataList.FirstOrDefault(x => x.Ident == id);
            if (found != null)
            {
                found = data;
            }
            else { throw new Exception("Update Model Failed!"); }
        }
    }
}
