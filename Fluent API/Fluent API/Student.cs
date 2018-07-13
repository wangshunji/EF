using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fluent_API
{

    #region 主键约定：主键必须是Id或类名+id(不区分大小写)

    public class Student
    {
        public int AddressId { get; set; }

        //主键约定：主键必须是Id或类名+id(不区分大小写)
        public int StudentID { get; set; }
    }

    #endregion


    #region 关系约定

    public class Department
    {
        //primary key
        public int DepartmentId { get; set; }
        public string Name { get; set; }

        //natvigation properties
        public virtual ICollection<Course> Courses { get; set; }
    }
    public class Course
    {
        //primary key
        public int CourseId { get; set; }
        public string Title { get; set; }
        public int Credits { get; set; }

        //Foregin key
        public int DepartmentId { get; set; }

        //navigation properties(导航属性)
        public virtual Department Deparment { get; set; }
    }

    #endregion


    #region 自定义约定

    public class CustomKeyConvention : Convention
    {
        /// <summary>
        /// 在OnModelCreating 调用
        /// </summary>
        public CustomKeyConvention()
        {
            //将属性名为Id的属性配置为主键且为全局应用
            Properties().Where(prop => prop.Name == "id").Configure(config => config.IsKey());
        }

    }
    //用来测试一个约定在另一个约定前执行，（指定约定的优先级）
    public class IdTestConvention:Convention{
        public IdTestConvention() {
            Properties().Where(prop=>prop.Name=="IdTest").Configure(c=>c.IsKey());

        }
    }


    #endregion

}
