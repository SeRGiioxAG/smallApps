using System;

namespace financeCalculator
{
    class Program
    {
        //Declaration of variables.
        private static double interestRate;
        private static double interest;
        private static double totalCost;
        private static double totalCostWithInterest;
        private static double monthsPayment;
        private static string financeYesNo;
        private static double monthlyPayment;

        static void Main(string[] args)
        {
            //Asking for data to fill the variables.
            Console.WriteLine("Select your interest rate:");
            interestRate = double.Parse(Console.ReadLine());
            Console.WriteLine("Now select the amount of money you want to finance:");
            totalCost = double.Parse(Console.ReadLine());
            Console.WriteLine("In how much months you want to pay the total cost?");
            monthsPayment = int.Parse(Console.ReadLine());
            while (monthsPayment < 0) //Restriction, so the user can't set a negative number in the monthsPayment variable.
            {
                Console.WriteLine("Please, enter a valid month.");
                monthsPayment = int.Parse(Console.ReadLine());
            }
            calculateInterest(); //Calls a function to calculate all the final data.
        }

        static void calculateInterest()
        {
            interest = interestRate * totalCost / 100; //This sets the amount of money you will have to pay as the interest (interest fee).
            totalCostWithInterest = totalCost + interest; 
            Console.WriteLine("Your total cost is {0}$, plus your interest rate of {1}% it now is: {2}$.", totalCost, interestRate, totalCostWithInterest); //Displays the relevant data for the user.
            Console.WriteLine("Do you want to finance this product(s)?");
            financeYesNo = Console.ReadLine();
            string firstResponse = financeYesNo.ToLower(); //Line 39 and line 40 lets the user respond the question with an affirmative answer. It sets the response to lowercase so it works with "yes" and "Yes".
            if (firstResponse.Contains("ye"))
            {//If the user said anything that contains "ye" like yes or yeah it shows the monthly payment of the financing.
                monthlyPayment = totalCostWithInterest / monthsPayment;
                Console.WriteLine("Your monthly payment will be of {0}$. To pay in {1} months.", monthlyPayment ,monthsPayment); //Displays the monthly payment of the user and the months to pay the totalcost.
            }
            else
            {//If he decides to not finance the purchase the program will end with the next message.
                Console.WriteLine("Thanks for using the program.");
            }
        }
    }
}