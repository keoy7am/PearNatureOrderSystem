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
    public class CategroyRepo : RepositoryBase<CategroyModel>
    {
        public CategroyRepo(RepositoryRegister repositoryRegister) : base(repositoryRegister)
        {

        }

        /// <summary>
        /// 依照iden Id 取值
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public override CategroyModel GetSingle(long id)
        {
            var found = _dataList.FirstOrDefault(x => x.Ident == id);
            return found;
        }

        /// <summary>
        /// 依照iden Id更新值
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public override void Update(long id, CategroyModel data)
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
