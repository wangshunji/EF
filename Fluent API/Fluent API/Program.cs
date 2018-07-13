using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fluent_API{

    class Program{
        static void Main(string[] args) {
            using (var efDbContext = new EfDbContext()) {
                Student[] studentlist = new Student[] {
                    new Student() {StudentID = 1, AddressId = 11},
                    new Student() {StudentID = 2, AddressId = 22}
                };

                efDbContext.Students.AddRange(studentlist);

                efDbContext.Blogs.Add(new Blog() {
                    Name = "ShunjiWang",
                    Url  = "http://shunji.wang"
                });

                efDbContext.SaveChanges();
            }
        }
    }

}
