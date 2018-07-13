using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Discriminator.DAL;
using Discriminator.Model;

namespace Discriminator
{  /// <summary>
/// Discriminator值  和 自定义Discriminator值
/// </summary>
    class Program
    {
        static void Main(string[] args)
        {
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
            }*/

            using (EfDbContext dbContext=new EfDbContext()) {
                var query = (from b in dbContext.BillingDetails.OfType<BankAccount>() select b).ToList();
                var quesry = (from s in dbContext.BillingDetails.OfType<CreditCard>() select s).ToList();
                int d = 0;
            }

        }
    }
}
