using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SqlSugar;
using BTDemo.Entities;

namespace BTDemo.DB
{
    /// <summary>
    /// 数据-操作实体
    /// </summary>
    public class DbEntities : DbContext
    {
        public SimpleClient<Categories> CategoriesDb
        {
            get { return new SimpleClient<Categories>(Db); }
        }
        public SimpleClient<CustomerCustomerDemo> CustomerCustomerDemoDb
        {
            get { return new SimpleClient<CustomerCustomerDemo>(Db); }
        }
        public SimpleClient<CustomerDemographics> CustomerDemographicsDb
        {
            get { return new SimpleClient<CustomerDemographics>(Db); }
        }
        public SimpleClient<Customers> CustomersDb
        {
            get { return new SimpleClient<Customers>(Db); }
        }
        public SimpleClient<Employees> EmployeesDb
        {
            get { return new SimpleClient<Employees>(Db); }
        }
        public SimpleClient<EmployeeTerritories> EmployeeTerritoriesDb
        {
            get { return new SimpleClient<EmployeeTerritories>(Db); }
        }
        public SimpleClient<OrderDetails> OrderDetailsDb
        {
            get { return new SimpleClient<OrderDetails>(Db); }
        }
        public SimpleClient<OrderDetailsBackup> OrderDetailsBackupDb
        {
            get { return new SimpleClient<OrderDetailsBackup>(Db); }
        }
        public SimpleClient<Orders> OrdersDb
        {
            get { return new SimpleClient<Orders>(Db); }
        }
        public SimpleClient<Products> ProductsDb
        {
            get { return new SimpleClient<Products>(Db); }
        }
        public SimpleClient<Region> RegionDb
        {
            get { return new SimpleClient<Region>(Db); }
        }
        public SimpleClient<Shippers> ShippersDb
        {
            get { return new SimpleClient<Shippers>(Db); }
        }
        public SimpleClient<Suppliers> SuppliersDb
        {
            get { return new SimpleClient<Suppliers>(Db); }
        }
        public SimpleClient<Territories> TerritoriesDb
        {
            get { return new SimpleClient<Territories>(Db); }
        }
    }
}