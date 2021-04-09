using System;

namespace Expenditure
{
    class FinanceApp
    {
        static void Main()
        {
            double grossIncome = 0;
            double monthlyTax = 0;
            string option = "";

            HomeLoan home = new HomeLoan(grossIncome, monthlyTax, option);
           
            Console.WriteLine("Enter your Gross monthly income(before deductions): ");
            grossIncome = Convert.ToDouble(Console.ReadLine());
            home.InputExpenditures();

            Console.WriteLine("Enter your estimated monthly tax deducted: ");
            monthlyTax = Convert.ToDouble(Console.ReadLine());
            home.CheckMonthlyTax(monthlyTax, grossIncome);

            Console.WriteLine("Enter A or B for your accomadation type:" + "\n" + "A) Rent" + "\n"
                              + "B) Purchase Property");
            option = Console.ReadLine();
            home.Selection(option);

            Console.WriteLine();
            Console.WriteLine("***************************************************");
            home.GrossIncome = grossIncome;
            Console.WriteLine("Gross Income: " + home.GrossIncome);
            Console.WriteLine("Monthly Tax: " + monthlyTax);
            Console.WriteLine("Total Monthly Expenditure(no tax included): " + home.GetExpenditureTotal());
            Console.WriteLine("Available Monthly Money(after tax and monthly expenditure is deducted): " + (home.GrossIncome - home.GetExpenditureTotal() - monthlyTax));
            Console.WriteLine("Total Loan Repayment: " + home.CalculateLoan());
            Console.WriteLine("Monthly loan repayment: " + home.GetMonthlyLoanRepayment());
            home.Alert();

        }
    }
}
