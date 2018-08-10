using SerializationRepository.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace SerializationRepository.Repositories
{
    public abstract class RepositoryBase<T> : IRepository<T> where T :  class
    {
        private readonly string _filePath;
        private readonly ISerializer _serializer;
        protected List<T> _dataList; // 考慮使否使用LazyList 

        protected RepositoryBase(RepositoryRegister serviceRegister)
        {
            this._serializer = serviceRegister.serializer;
            this._filePath = serviceRegister.FilePath;
            // 檔案不存在時自動建立檔案
            if (!File.Exists(_filePath))
            {
                using (var writer = new StreamWriter(_filePath, false))
                {
                    writer.Write("");
                    writer.Close();
                }
            }
            _dataList = _serializer.SerializeFromFile<T>(_filePath);
            // 當檔案為空時自動建立新的List
            if (_dataList == null)
            {
                _dataList = new List<T>();
            }
        }

        protected RepositoryBase(ISerializer serializer, string filePath)
        {
            this._serializer = serializer;
            this._filePath = filePath;
            // 檔案不存在時自動建立檔案
            if (!File.Exists(_filePath))
            {
                using (var writer = new StreamWriter(_filePath, false))
                {
                    writer.Write("");
                    writer.Close();
                }
            }
            _dataList = _serializer.SerializeFromFile<T>(_filePath);
            // 當檔案為空時自動建立新的List
            if (_dataList == null)
            {
                _dataList = new List<T>();
            }
        }

        public virtual IList<T> GetAll()
        {
            return _dataList.ToList();
        }

        /// <summary>
        /// 依照List內的index取值
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public virtual T GetSingle(long id)
        {
            return _dataList[Convert.ToInt32(id) - 1];
        }

        /// <summary>
        /// 依照List內的index更新值
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public virtual void Update(long id, T data)
        {
            _dataList[Convert.ToInt32(id) - 1] = data;
        }

        public virtual void Add(T data)
        {
            _dataList.Add(data);
        }

        public virtual void Delete(T data)
        {
            _dataList.Remove(data);
        }

        public virtual bool Save()
        {
            return (_serializer.SerializeToFile(_dataList, _filePath));
        }
    }
}
