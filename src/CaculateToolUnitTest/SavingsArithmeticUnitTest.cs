using CaculateCommon;
using CaculateCommon.Arithmetic;
using NUnit.Framework;

namespace CaculateToolUnitTest
{
    [TestFixture]
    public class SavingsArithmeticUnitTest
    {
        [TestCase(1000000, 1, 0.1, 10000, 1226500.04)]
        [TestCase(10000, 1, 0.1, 1000, 23650.004)]
        [TestCase(0, 1, 1, 1000, 18500.04)]
        public void Caculate_BaseInfo_RightResult(
            double baseAmount,
            double years,
            double annualizedReturn,
            double repaymentOfMonth,
            double exceptResult)
        {
            // Arrange
            var baseInfo = new BaseInfo()
            {
                BaseAmount = baseAmount,
                Years = years,
                AnnualizedReturn = annualizedReturn,
                RepaymentOfMonth = repaymentOfMonth
            };
            var savingsArithmetic = new SavingsArithmetic(baseInfo);

            // Action
            var yearResult = savingsArithmetic.Caculate();

            // Assert
            Assert.AreEqual(yearResult.Count, years);
            Assert.AreEqual(exceptResult, yearResult[yearResult.Count - 1].Amount);
        }

    }
}
