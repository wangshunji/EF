using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Discriminator.DAL;
using Discriminator.Model;

using Newtonsoft.Json;

namespace Discriminator{

    /// <summary>
    /// Discriminator值  和 自定义Discriminator值
    /// </summary>
    class Program{
        static void Main(string[] args) {
            /**
            using (EfDbContext d = new EfDbContext()) {
                d.BillingDetails.Add(new BankAccount {
                    BankName        = "中国银行帐户",
                    BillingDetailId = 1,
                    Number          = "23412340",
                    Owner           = "shunji",
                    Swift           = "中国银行"

                });

                d.SaveChanges();
            }

            using (EfDbContext dbContext=new EfDbContext()) {
                var query = (from b in dbContext.BillingDetails.OfType<BankAccount>() select b).ToList();
                var quesry = (from s in dbContext.BillingDetails.OfType<CreditCard>() select s).ToList();
                int d = 0;
            }
    

            using (var ef=new EfDbContext()) {
                Test_User user = new Test_User() {
                    Birthdate = DateTime.Now,
                    CreatedTime = DateTime.Now,
                    ModifiedTime = DateTime.Now,
                    Name = "shunji",
                    IDNumber = "235234523452345"
                    ,Address  =new Address(){}
                };

                ef.Users2.Add(user);
                ef.SaveChanges();

            }
     
            using (EfDbContext ef = new EfDbContext()) {
                Test_User user = new Test_User() {
                    ID = 2,
                    Birthdate    = DateTime.Now,
                    CreatedTime  = DateTime.Now,
                    ModifiedTime = DateTime.Now,
                    Name     = "shunjiwang",
                    IDNumber = "235234523452345",
                    Address = new Address() {
                        Street  = "shanghai_jiading",
                        city    = "shanghai",
                        ZipCode = "201803"
                    }
                };

                ef.Entry(user).State = EntityState.Deleted;
                ef.SaveChanges();
            }
            */
            using (var ef = new EfDbContext()) {
                ef.Database.Log = Console.WriteLine;

                //var user = ef.Users2.FirstOrDefault();
                var customer          = ef.Customers.FirstOrDefault();
                var serializeCustomer = JsonConvert.SerializeObject(customer);
                var order             = customer.Orders; //延迟加载关闭后，这里的结果是null

                //延迟加载关闭后  显式加载依然可以延迟执行，这里有结果
                var order1 = ef.Entry(customer)
                        .Collection(d => d.Orders)
                        .Query()
                        .ToList();
                //原始查询
                var customer1 = ef.Database.SqlQuery<Customer>("select * from dbo.Customers").ToList();
                var customer2 = ef.Customers.SqlQuery("select * from dbo.Customers").ToList();

                Console.ReadKey();
            }
        }
    }

}
