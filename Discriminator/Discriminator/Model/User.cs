using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discriminator.Model{

    public class User{
        /// <summary>
        /// 主键，用户ID
        /// </summary>
        public int UserId { get; set; }
        /// <summary>
        /// 用户名
        /// </summary>
        public string UserName { get; set; }
        /// <summary>
        /// 用户的真实姓名
        /// </summary>
        public string RealName { get; set; }
        /// <summary>
        /// 手机号
        /// </summary>
        public int Phone { get; set; }
        /// <summary>
        /// 密码
        /// </summary>
        public string Password { get; set; }
    }

}
