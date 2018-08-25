using LiteDB;
using PearNatureOrderSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Linq;
using System.Windows.Forms;

namespace PearNatureOrderSystem.Services
{
    public class CategoryServices
    {
        public delegate void CategoryChangedEvent();
        public static event CategoryChangedEvent CategoryChanged;
        public delegate void ProductChangedEvent();
        public static event ProductChangedEvent ProductChanged;
        public delegate void ProductRemarkChangedEvent();
        public static event ProductRemarkChangedEvent ProductRemarkChanged;
        
        #region Misc
        public static BindingSource GetCateSource()
        {
            var bindingList = new BindingList<CategoryModel>(GetAllCates());
            var source = new BindingSource(bindingList, null);
            return source;
        }
        public static BindingSource GetProductSourceByCateID(long id)
        {
            var bindingList = new BindingList<ProductModel>(QueryProductsByCateId(id));
            var source = new BindingSource(bindingList, null);
            return source;
        }
        public static List<CategoryModel> GetAllCates()
        {
            List<CategoryModel> cate = new List<CategoryModel>();
            using (var db = new LiteDatabase(ConfigurationManager.AppSettings["DBName"].ToString().Trim()))
            {
                // Get customer collection
                var cates = db.GetCollection<CategoryModel>("categories");
                cate = cates.FindAll().ToList();
            }
            return cate;
        }
        #endregion
        #region Create
        public bool InsertTable(CategoryModel categoryModel)
        {
            try
            {
                using (var db = new LiteDatabase(ConfigurationManager.AppSettings["DBName"].ToString().Trim()))
                {
                    var cates = db.GetCollection<CategoryModel>("categories");
                    var cate = cates.Find(x => x.Id == categoryModel.Id).FirstOrDefault();

                    if (cate == null)
                    {
                        cates.Insert(categoryModel);
                        CategoryChanged();
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                // log here
                return false;
            }
        }
        #endregion
        #region Read
        public static List<ProductModel> QueryProductsByCateId(long id)
        {
            List<ProductModel> products;
            using (var db = new LiteDatabase(ConfigurationManager.AppSettings["DBName"].ToString().Trim()))
            {
                // Get customer collection
                var cates = db.GetCollection<CategoryModel>("categories");
                var cate = cates.Find(x => x.Id == id).FirstOrDefault();
                products = cate.Products;
            }
            return products;
        }
        public CategoryModel QueryCategoryById(long id)
        {
            CategoryModel categoryModel;
            using (var db = new LiteDatabase(ConfigurationManager.AppSettings["DBName"].ToString().Trim()))
            {
                // Get customer collection
                var cates = db.GetCollection<CategoryModel>("categories");
                var cate = cates.Find(x => x.Id == id).FirstOrDefault();
                categoryModel = cate;
            }
            return categoryModel;
        }
        #endregion
        #region Update
        /// <summary>
        /// 更新產品分類
        /// </summary>
        /// <param name="categoryModel"></param>
        /// <param name="productChanged">判別是否為更新產品 true:更新產品即刷新產品清單 false:更新分類即更新分類清單</param>
        /// <returns></returns>
        public bool UpdateTable(CategoryModel categoryModel,bool productChanged=false)
        {
            try
            {
                using (var db = new LiteDatabase(ConfigurationManager.AppSettings["DBName"].ToString().Trim()))
                {
                    var cates = db.GetCollection<CategoryModel>("categories");

                    var cate = cates.Find(x => x.Id == categoryModel.Id).FirstOrDefault();
                    if (cate != null)
                    {
                        cate = categoryModel;
                        cates.Update(cate);
                        if (productChanged)
                        {
                            ProductChanged();
                        }
                        else
                        {
                            CategoryChanged();
                        }
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
        public bool DeleteTable(CategoryModel categoryModel)
        {
            try
            {
                using (var db = new LiteDatabase(ConfigurationManager.AppSettings["DBName"].ToString().Trim()))
                {
                    var cates = db.GetCollection<CategoryModel>("categories");

                    var cate = cates.Find(x => x.Id == categoryModel.Id).FirstOrDefault();
                    if (cate != null)
                    {
                        cates.Delete(x => x.Id == categoryModel.Id);
                        CategoryChanged();
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
        public bool DeleteTable(long id)
        {
            try
            {
                using (var db = new LiteDatabase(ConfigurationManager.AppSettings["DBName"].ToString().Trim()))
                {
                    var cates = db.GetCollection<CategoryModel>("categories");

                    var cate = cates.Find(x => x.Id == id).FirstOrDefault();
                    if (cate != null)
                    {
                        cates.Delete(x => x.Id == id);
                        CategoryChanged();
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
