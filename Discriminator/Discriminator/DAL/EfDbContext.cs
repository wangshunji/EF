using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

using Discriminator.Model;

namespace Discriminator.DAL{
    public class Myconfiguration : DbConfiguration
    {
        public Myconfiguration()
        {
            SetDefaultConnectionFactory(new System.Data.Entity.Infrastructure.LocalDbConnectionFactory("mssqllocaldb"));
        }
    }
    [DbConfigurationType(typeof(Discriminator.DAL.Myconfiguration))]
    public class EfDbContext : DbContext{
        public EfDbContext() : base("Name=DiscriminatorConn") {
             // Database.SetInitializer<EfDbContext>(null);
            //使用DbConfiguration后这里就不用配置了
               Database.SetInitializer( new DropCreateDatabaseIfModelChanges<EfDbContext>());
        }

        //使用dbset来显露基类属性
        public DbSet<BillingDetail> BillingDetails { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Test_PriKey> PriKeys { get; set; }
        /// <summary>
        /// 配置映射的方法
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(DbModelBuilder modelBuilder) {
            //自定义Discriminator值,对继承层次的类型进行区分（不同类型的返回值不同）
            //没有自定义的话系统会在表中自动加一个Discriminator列区分 ，这里自定义了所加BillingDetailType
            modelBuilder.Entity<BillingDetail>().Map<BankAccount>(m => m.Requires("BillingDetailType").HasValue(1))
                    .Map<CreditCard>(m => m.Requires("BillingDetailType").HasValue(2));
            //（手动配置表名）给实体起个表名,不配置的话默认是模型名称
            modelBuilder.Entity<User>().ToTable("User_Test");
            //（手动配置主键）  HasDatabaseGeneratedOption的三个枚举：Identity(标识列),Computed（计算列）,None（手动分配其值）
            //如果没有手动配置主键，默认主键是Id 或 模型名+Id 
            modelBuilder.Entity<Test_PriKey>().HasKey(key => key.DD).Property(p => p.DD)
                    .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);//为主键指定值的生成方式 

        }
    }

    

}
