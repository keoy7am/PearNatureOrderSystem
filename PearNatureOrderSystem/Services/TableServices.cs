using LiteDB;
using PearNatureOrderSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PearNatureOrderSystem.Services
{
    public class TableServices
    {
        public delegate void TableChangedEvent();
        public static event TableChangedEvent TableChanged;

        public static void InitTableSerices()
        {
        }
        #region Misc
        public static BindingSource GetTableSource()
        {
            var bindingList = new BindingList<TableModel>(GetAllTables());
            var source = new BindingSource(bindingList, null);
            return source;
        }
        public static List<TableModel> GetAllTables()
        {
            List<TableModel> tables = new List<TableModel>();
            using (var db = new LiteDatabase(@"Local.db"))
            {
                // Get customer collection
                var users = db.GetCollection<TableModel>("tables");
                tables = users.FindAll().ToList();
            }
            return tables;
        }
        #endregion
        #region Create
        public bool InsertTable(TableModel tableModel)
        {
            try
            {
                using (var db = new LiteDatabase(@"Local.db"))
                {
                    var tables = db.GetCollection<TableModel>("tables");

                    var table = tables.Find(x => x.Id == tableModel.Id).FirstOrDefault();
                    if (table == null)
                    {
                        tables.Insert(tableModel);
                        TableChanged();
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
        public bool QueryTableById()
        {
            return true;
        }

        #endregion
        #region Update
        public bool UpdateTable(TableModel tableModel)
        {
            try
            {
                using (var db = new LiteDatabase(@"Local.db"))
                {
                    var tables = db.GetCollection<TableModel>("tables");

                    var table = tables.Find(x => x.Id == tableModel.Id).FirstOrDefault();
                    if (table != null)
                    {
                        table = tableModel;
                        tables.Update(table);
                        TableChanged();
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
        public bool DeleteTable(TableModel tableModel)
        {
            try
            {
                using (var db = new LiteDatabase(@"Local.db"))
                {
                    var tables = db.GetCollection<TableModel>("tables");

                    var table = tables.Find(x => x.Id == tableModel.Id).FirstOrDefault();
                    if (table != null)
                    {
                        tables.Delete(x => x.Id == tableModel.Id);
                        TableChanged();
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
                using (var db = new LiteDatabase(@"Local.db"))
                {
                    var tables = db.GetCollection<TableModel>("tables");

                    var table = tables.Find(x => x.Id == id).FirstOrDefault();
                    if (table != null)
                    {
                        tables.Delete(x => x.Id == id);
                        TableChanged();
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
