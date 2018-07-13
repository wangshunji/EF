using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fluent_API{

    /// <summary>
    /// 这是一个领域模型。
    /// </summary>
    public class Blog{
        public int       Id         { get; set; }
        public string    Name       { get; set; }
        public string    Url        { get; set; }
        public DateTime? CreateTime { get; set; }
        public double    Double     { get; set; }
        public float     Float      { get; set; }
    }

}
