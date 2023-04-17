using MiniExcelLibs.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KiteTools.ModelBuilder.Models
{
    internal class Fields
    {
        /// <summary>
        /// 注释
        /// </summary>
        [ExcelColumnName("注释")]
        public string? Annotation { get; set; }

        /// <summary>
        /// 字段名
        /// </summary>
        [ExcelColumnName("字段名")]
        public string FieldName { get; set; } = string.Empty;

        /// <summary>
        /// 字段类型
        /// </summary>
        [ExcelColumnName("字段类型")]
        public string FieldType { get; set; } = string.Empty;

        /// <summary>
        /// Display特性名
        /// </summary>
        [ExcelColumnName("Display")]
        public string? Display { get; set; }

        /// <summary>
        /// 是否非空字段
        /// </summary>
        [ExcelColumnName("Required")]
        public string? Required  { get; set; }
    }


}
