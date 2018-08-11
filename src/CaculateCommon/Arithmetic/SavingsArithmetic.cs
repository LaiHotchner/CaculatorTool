using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaculateCommon.Arithmetic
{
    public class SavingsArithmetic
    {
        private BaseInfo _baseInfo;

        public SavingsArithmetic(BaseInfo baseInfo)
        {
            _baseInfo = baseInfo;
        }

        public List<YearResult> Caculate()
        {
            var yearResultList = new List<YearResult>();
            var currentAmount = _baseInfo.BaseAmount;
            for (int i = 0; i < _baseInfo.Years; i++)
            {
                var yearResult = CaculateOneYear(i+1, currentAmount);
                currentAmount = yearResult.Amount;
                yearResultList.Add(yearResult);
            }
            return yearResultList;
        }

        private YearResult CaculateOneYear(int index, double currentAmount)
        {
            var result = new YearResult();
            result.LastAmount = currentAmount;
            result.Name = $"第{index}年，";
            result.FixedInterset = result.LastAmount * _baseInfo.AnnualizedReturn;
            result.Deposit = _baseInfo.RepaymentOfMonth * 12;
            result.Interest = _baseInfo.RepaymentOfMonth * 12 * (_baseInfo.AnnualizedReturn * Help.FloatRate);
            return result;
        }
    }
}
