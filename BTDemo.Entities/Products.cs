using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace BTDemo.Entities
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("Products")]
    public partial class Products
    {
           public Products(){

            this.UnitPrice =Convert.ToDecimal("0");
            this.UnitsInStock =Convert.ToInt16("0");
            this.UnitsOnOrder =Convert.ToInt16("0");
            this.ReorderLevel =Convert.ToInt16("0");
            this.Discontinued =false;

           }
           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true,IsIdentity=true)]
           public int ProductID {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string ProductName {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? SupplierID {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? CategoryID {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string QuantityPerUnit {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public decimal? UnitPrice {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public short? UnitsInStock {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public short? UnitsOnOrder {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public short? ReorderLevel {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public bool Discontinued {get;set;}

    }
}
