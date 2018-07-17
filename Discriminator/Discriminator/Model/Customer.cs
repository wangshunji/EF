using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discriminator.Model
{
  public  class Customer:BaseEntity
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public virtual  ICollection<Orders> Orders { get; set; }
    }

    public class Orders:BaseEntity
    {
        public string Quanatity { get; set; }
        public int Price { get; set; }

        public int CustomerId { get; set; }
    }
}
