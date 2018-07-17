using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discriminator.Model
{
    /// <summary>
    /// 实体的基类
    /// </summary>
  public abstract  class BaseEntity
    {public int ID { get; set; }
        public DateTime ModifiedTime { get; set; }
        public DateTime CreatedTime { get; set; }
    }
}
