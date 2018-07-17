using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using  System.Data.Entity;

namespace Discriminator.Model{

    
    public class Test_User:BaseEntity{
        public string   Name      { get; set; }
        public string   IDNumber  { get; set; }
        public DateTime Birthdate { get; set; }
        public Address  Address   { get; set; }
    }
    public class Address{
        public string Street  { get; set; }
        public string city    { get; set; }
        public string ZipCode { get; set; }
        public bool HasValue {
            get { return (Street != null || city != null || ZipCode != null); }
        }

    }

}
