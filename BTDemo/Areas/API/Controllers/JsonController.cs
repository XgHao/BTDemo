using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using BTDemo.DB;
using BTDemo.Entities;
using SqlSugar;
using BTDemo.Areas.API.Formatter;

namespace BTDemo.Areas.API.Controllers
{
    /// <summary>
    /// Json格式数据
    /// </summary>
    public class JsonController : Controller
    {
        public ActionResult Categories(string BtText="")
        {
            return ReturnJson<Categories>(BtText);
        }
        public ActionResult CustomerCustomerDemo(string BtText = "")
        {
            return ReturnJson<CustomerCustomerDemo>(BtText);
        }
        public ActionResult CustomerDemographics(string BtText = "")
        {
            return ReturnJson<CustomerDemographics>(BtText);
        }
        public ActionResult Customers(string BtText = "")
        {
            return ReturnJson<Customers>(BtText);
        }
        public ActionResult Employees(string BtText = "")
        {
            return ReturnJson<Employees>(BtText);
        }
        public ActionResult EmployeeTerritories(string BtText = "")
        {
            return ReturnJson<EmployeeTerritories>(BtText);
        }
        public ActionResult OrderDetails(string BtText = "")
        {
            return ReturnJson<OrderDetails>(BtText);
        }
        public ActionResult OrderDetailsBackup(string BtText = "")
        {
            return ReturnJson<OrderDetailsBackup>(BtText);
        }
        public ActionResult Orders(string BtText = "")
        {
            return ReturnJson<Orders>(BtText);
        }
        public ActionResult Products(string BtText = "")
        {
            return ReturnJson<Products>(BtText);
        }
        public ActionResult Region(string BtText = "")
        {
            return ReturnJson<Region>(BtText);
        }
        public ActionResult Shippers(string BtText = "")
        {
            return ReturnJson<Shippers>(BtText);
        }
        public ActionResult Suppliers(string BtText = "")
        {
            return ReturnJson<Suppliers>(BtText);
        }
        public ActionResult Territories(string BtText = "")
        {
            return ReturnJson<Territories>(BtText);
        }


        /// <summary>
        /// 返回json结果
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="BtText"></param>
        /// <returns></returns>
        private ActionResult ReturnJson<T>(string BtText) where T : class, new()
        {
            return BtText.Equals("BT") ? Json(JsonFormat.GetJson<T>(true), JsonRequestBehavior.AllowGet) : Json(JsonFormat.GetJson<T>(false), JsonRequestBehavior.AllowGet);
        }
    }
}