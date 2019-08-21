using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BTDemo.DB;
using SqlSugar;

namespace BTDemo.Controllers
{
    /// <summary>
    /// DbFirst-数据库先行
    /// </summary>
    public class DBFirstController : Controller
    {
        /// <summary>
        /// 生成实体类
        /// </summary>
        /// <returns></returns>
        public ActionResult CreateEntities()
        {
            string path = @"C:\northwind\EntityModels";
            var db = new DbContext().Db;
            List<DbTableInfo> DbTables = db.DbMaintenance.GetTableInfoList();
            foreach (var dbtable in DbTables)
            {
                //去掉数据库表名中含有的“空格”
                db.MappingTables.Add(dbtable.Name.Replace(" ", ""), dbtable.Name);
            }
            try
            {
                db.DbFirst.IsCreateAttribute().IsCreateDefaultValue().CreateClassFile(path, "BTDemo.Entities");
                return View("导出成功! 路径：" + path);
            }
            catch
            {
                return View("出错了。");
            }
        }
    }
}