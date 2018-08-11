using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaculateCommon
{
    public class YearResult
    {
        public string Name { get; set; }

        /// <summary>
        /// 上一到年度总额
        /// </summary>
        public double LastAmount { get; set; }

        /// <summary>
        /// 固定存款利息
        /// </summary>
        public double FixedInterset { get; set; }

        /// <summary>
        /// 当年存入
        /// </summary>
        public double Deposit { get; set; }

        /// <summary>
        /// 当前存款存入浮动利息
        /// </summary>
        public double Interest { get; set; }

        /// <summary>
        /// 年度总额
        /// </summary>
        public double Amount
        {
            get
            {
                return LastAmount + FixedInterset + Deposit + Interest;
            }
        }

        public override string ToString()
        {
            var result = $"{Name}" +
                $"当前总额：{Amount / 10000}万；\r\n" +
                $"上年余额：{LastAmount / 10000}万，" +
                $"固定利息：{FixedInterset / 10000}万 " +
                $"本年存入：{Deposit / 10000}万，" +
                $"浮动利息：{Interest / 10000}万。";
            return result;
        }
    }
}
