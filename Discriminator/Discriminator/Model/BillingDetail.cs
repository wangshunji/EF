using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discriminator.Model{

    /// <summary>
    /// 帐户明细
    /// </summary>
    public abstract class BillingDetail{
        /// <summary>
        /// 帐户明细ID
        /// </summary>
        public int BillingDetailId { get; set; }
        /// <summary>
        /// 帐户所有者
        /// </summary>
        public string Owner { get; set; }
        /// <summary>
        /// 帐号
        /// </summary>
        public string Number { get; set; }
    }
    /// <summary>
    /// 帐号
    /// </summary>
    public class BankAccount : BillingDetail{
        /// <summary>
        /// 帐户名称
        /// </summary>
        public string BankName { get; set; }
        /// <summary>
        /// 所属金融银行
        /// </summary>
        public String Swift { get; set; }
    }

    /// <summary>
    /// 信用卡
    /// </summary>
    public class CreditCard : BillingDetail{
        /// <summary>
        /// 信用卡类型
        /// </summary>
        public int CardType { get; set; }
        /// <summary>
        /// 信用卡失效月份
        /// </summary>
        public string ExpiryMonth { get; set; }
        /// <summary>
        /// 信用卡失效年份
        /// </summary>
        public string ExpiryYear { get; set; }
    }

}
