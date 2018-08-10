using System;
using System.Collections.Generic;
using System.Text;

namespace SerializationRepository.Interfaces
{
    public interface IRepository<T>
    {
        /// <summary>
        /// 取得全部資料
        /// </summary>
        /// <returns></returns>
        IList<T> GetAll();

        /// <summary>
        /// 取單筆資料
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        T GetSingle(long id);

        /// <summary>
        /// 依照Primary key ID更新資料
        /// </summary>
        /// <param name="id"></param>
        /// <param name="data"></param>
        void Update(long id, T data);

        /// <summary> 
        /// 加入單筆資料
        /// </summary> 
        /// <param name="entity">欲加入的資料</param> 
        /// <returns></returns> 
        void Add(T entity);

        /// <summary> 
        /// 移除單筆資料
        /// </summary> 
        /// <param name="entity">欲刪除的資料</param> 
        void Delete(T entity);

        /// <summary>
        /// 儲存資料 (序列化到檔案) 
        /// </summary>
        bool Save();
    }
}
