using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discriminator.Model{

    /// <summary>
    /// 数值和字符的映射
    /// </summary>
    public class Test_Num{
        /// <summary>
        /// 主键
        /// </summary>
        public int id { get; set; }


        #region 数值型

        /// <summary>
        /// int 对应数据库中的Int
        /// </summary>
        public int IntNum { get; set; }
        /// <summary>
        /// double对应数据库中的float
        /// </summary>
        public double DoubleNum { get; set; }
        /// <summary>
        /// float 对应数据库中的real
        /// </summary>
        public float FloatNum { get; set; }
        /// <summary>
        /// decimal默认对应数据库中的decimal(18,2)，只保留两位小数
        /// </summary>
        public decimal DecimalNum { get; set; }
        /// <summary>
        /// 把decimal的后面小数保留至4位
        /// </summary>
        public decimal DecimalNum4 { get; set; }
        /// <summary>
        /// int64对应数据库中的bigint
        /// </summary>
        public Int64 Int64Num { get; set; }

        #endregion


        #region 字符型 数据库中的所有字符默认对应c#中的string"

        /// <summary>
        /// string 默认对应nvarchar(max)
        /// </summary>
        public string StringStr { get; set; }
        /// <summary>
        /// 把string 指定 对应nvarchar(50)
        /// </summary>
        public string String50Str { get; set; }
        /// <summary>
        /// 把string 指定 对应varchar(50),  char的指定和此类似
        /// </summary>
        public string Varchar50Str { get; set; }
        /// <summary>
        /// 把string 指定 对应char(50)
        /// </summary>
        public string Char50Str { get; set; }
        /// <summary>
        /// 把char 指定为数据中的char,会报错，这是把string 指定 对应数据库中nchar的另一种方法
        /// </summary>
        public string Char11Str { get; set; }
        /// <summary>
        /// 指定string 映射到数据库为varchar(max) 最大长度,其它类似
        /// </summary>
        public string VarcharMaxStr { get; set; }

        #endregion
    }

}
