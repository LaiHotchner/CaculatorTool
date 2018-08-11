using CaculateCommon;
using CaculateCommon.Arithmetic;
using System;

namespace CaculatorConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var quitFlag = false;
            while (!quitFlag)
            {
                InputCollection();
                Console.WriteLine("Is Quit?");
                var input = Console.ReadLine();
                quitFlag = string.Compare(input, "q", true) == 0;
            }
        }


        static void InputCollection()
        {
            Console.WriteLine("Please input the baseAmount: (万元)");
            int.TryParse(Console.ReadLine(), out int amount);
            amount = amount * 10000;

            Console.WriteLine("Please input the Years: ");
            int.TryParse(Console.ReadLine(), out int years);

            Console.WriteLine("Please input the Annualized Return: (年化收益率)");
            int.TryParse(Console.ReadLine(), out int annualizedReturn);
            double annualizedReturnRate = annualizedReturn / 100.0;

            Console.WriteLine("Please input the Repayment Of Month: (每月还款额)");
            int.TryParse(Console.ReadLine(), out int repaymentOfMonth);

            var baseInfo = new BaseInfo()
            {
                BaseAmount = amount,
                Years = years,
                AnnualizedReturn = annualizedReturnRate,
                RepaymentOfMonth = repaymentOfMonth
            };
            var savingsArithmetic = new SavingsArithmetic(baseInfo);
            var yearResult = savingsArithmetic.Caculate();
            foreach (var year in yearResult)
            {
                Console.WriteLine(year.ToString());
            }
            Console.WriteLine("Finished\r\n");
        }
    }
}
