using BTDemo.DB;
using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using Newtonsoft.Json;
using BTDemo.Areas.API.Models;

namespace BTDemo.Areas.API.Formatter
{
    public static class JsonFormat
    {
        /// <summary>
        /// 根据传入类型-返回对应List
        /// </summary>
        /// <typeparam name="T">数据库的表名</typeparam>
        /// <param name="isBootstrapTable">是否返回BT格式的</param>
        /// <returns></returns>
        public static Object GetJson<T>(bool isBootstrapTable = false) where T : class, new()
        {
            List<T> Lists = new List<T>();

            //传入泛型类
            Type EntityType = typeof(T);     //--Customers

            //数据连接实体
            Type DbE = typeof(DbEntities);   //DbE.CustomersDb

            try
            {
                //获取当前属性对象
                PropertyInfo property = DbE.GetProperty(EntityType.Name + "Db");

                //返回对象对应属性的值
                var result = property.GetValue(new DbEntities()) as SimpleClient<T>;

                //返回SimpleClient对象的List
                Lists = result.GetList();

            }
            catch { }

            //是否返回BootstrapTable类型的Json
            if (isBootstrapTable)
            {
                var rows = JsonConvert.SerializeObject(Lists);
                string model = "{\"total\":" + Lists.Count + ",\"totalNotFiltered\":" + Lists.Count + ",\"rows\":" + rows + "}";

                TablePaginModel<T> paginModel = JsonConvert.DeserializeObject<TablePaginModel<T>>(model);
                return paginModel;
            }
            return Lists;
        }

    }
}