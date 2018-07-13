using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fluent_API{

    /// <summary>
    /// 创建一个继承EF上下文的类，此上下文是与数据库交互的一个中间桥梁
    /// </summary>
    public class EfDbContext : DbContext{
        //EF中配置的数据库连接默认为LocalDb本地数据库连接，
        //但是我们可以手动通过Ef上下文派生类的构造函数来配置数据连接
        public EfDbContext() : base("Name=ConnectName") {
            //数据库初始化策略
            /*Database.SetInitializer(new DropCreateDatabaseIfModelChanges<EfDbContext>());
              Database.SetInitializer(new DropCreateDatabaseAlways <EfDbContext>());
              Database.SetInitializer(new CreateDatabaseIfNotExists <EfDbContext>());*/
            Database.SetInitializer<EfDbContext>(null);
        }

        //为每一个模型公开一个DbSet,有三种方法

        // 用DbSet
        public DbSet<Blog>    Blogs    { get; set; }
        public DbSet<Student> Students { get; set; }

        /*  //用IDbSet
          public IDbSet<Blog> Blogs { get; set; }
          //只读设置属性
          public DbSet<Blog> Blogs {
              get { return Set<Blog>(); }
          }
        */
        protected override void OnModelCreating(DbModelBuilder modelBuilder) {
            //使用自定义约定指定主键
            modelBuilder.Conventions.Add<CustomKeyConvention>();

            //CustomKeyConvention约定将在IdTestConvention之前执行
            modelBuilder.Conventions.AddBefore<IdTestConvention>(new CustomKeyConvention());

            modelBuilder.Properties().Where(x => x.GetCustomAttributes(false).OfType<NonUnicode>().Any())
                    .Configure(c => c.IsUnicode(false));
        }

        public class NonUnicode : Attribute{ }
    }

}
