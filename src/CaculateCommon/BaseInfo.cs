using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaculateCommon
{
    public class BaseInfo
    {
        /// <summary>
        /// 基础存款
        /// </summary>
        public double BaseAmount { get; set; }

        /// <summary>
        /// 贷款年限
        /// </summary>
        public double Years { get; set; }

        /// <summary>
        /// 年化收益率
        /// </summary>
        public double AnnualizedReturn { get; set; }

        /// <summary>
        /// 每月还款额
        /// </summary>
        public double RepaymentOfMonth { get; set; }

    }

    public static class Help
    {
        public const double FloatRate = 0.54167;
    }

}
