using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discriminator.Model{

    /// <summary>
    /// 日期类型的映射
    /// </summary>
    public class Test_Date{
        public  int Id { get; set; }
        /// <summary>
        /// 日期类型默认映射为数据库中的datetime
        /// </summary>
        public DateTime DateTime { get; set; }
        /// <summary>
        /// 把Datetime 对应为数据库中的date
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// 把Datetime 对应为数据库中的datetime2(7)
        /// </summary>
        public DateTime DateTime2 { get; set; }

        /// <summary>
        /// 把Datetime 对应为数据库中的datetimeoffset(7)
        /// </summary>
        public DateTimeOffset DateTimeOffset { get; set; }

        /// <summary>
        /// 把Datetime 对应为数据库中的smalldatetime
        /// </summary>
        public DateTime SmallDateTime { get; set; }

        /// <summary>
        /// TimeSpan默认对应的是数据库中的time(7)
        /// </summary>
        public TimeSpan TimeSpan { get; set; }

    }

}
