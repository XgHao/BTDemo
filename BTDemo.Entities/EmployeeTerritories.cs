using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace BTDemo.Entities
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("EmployeeTerritories")]
    public partial class EmployeeTerritories
    {
           public EmployeeTerritories(){


           }
           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public int EmployeeID {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public string TerritoryID {get;set;}

    }
}
