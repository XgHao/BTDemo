using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BTDemo.Areas.API.Models
{
    /// <summary>
    /// BootstrapTable - 分页模型类
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class TablePaginModel<T>
    {
        /// <summary>
        /// 总数
        /// </summary>
        public int total { get; set; }

        /// <summary>
        /// 未被过滤的数量
        /// </summary>
        public int totalNotFiltered { get; set; }

        /// <summary>
        /// 具体数据集合
        /// </summary>
        public List<T> rows { get; set; }
    }
}