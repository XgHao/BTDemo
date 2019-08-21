using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using SqlSugar;

namespace BTDemo.DB
{
    public class DbContext
    {
        /// <summary>
        /// 数据库连接-配置信息
        /// </summary>
        private static ConnectionConfig Connection = new ConnectionConfig
        {
            ConnectionString = ConfigurationManager.AppSettings["DBConn"].ToString(),
            DbType = DbType.SqlServer,
            IsAutoCloseConnection = true,
            InitKeyType = InitKeyType.Attribute
        };

        /// <summary>
        /// 连接实例
        /// </summary>
        public SqlSugarClient Db;

        public DbContext()
        {
            Db = new SqlSugarClient(Connection);
        }
    }
}