using Microsoft.VisualBasic.FileIO;

namespace BankingServices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //system setup (system storage)
            int accountNumber = 0;
            string holderName = "";
            double balance = 0.0;
            bool isActive = false;
            char accountType = '-';
            bool isEmployed = false;
            double salary = 0.0;
            int creditScore = 0;
            int age = 0;
            double deposit = 0.0;
            double withdrawal = 0.0;
            double annualRate = 0.0;
            double avgBalance = 0.0;

            Console.WriteLine("1)  Account Number      (int)    current: 0 ");
            Console.WriteLine("2)  Holder Name         (string) current: [not set]");
            Console.WriteLine("3)  Balance             (double) current: 0.000 OMR ");
            Console.WriteLine("4)  Account Active?     (bool)   current: false   [enter 1=yes / 0=no] ");
            Console.WriteLine("5)  Account Type        (char)   current:   [enter S / C / F]");
            Console.WriteLine(" --- Customer Profile ---");
            Console.WriteLine("6)  Employed?           (bool)   current: false [enter 1=yes / 0=no]");
            Console.WriteLine("7)  Monthly Salary      (double) current: 0.000 OMR ");
            Console.WriteLine("8)  Credit Score        (int)    current: 0 ");
            Console.WriteLine("9)  Age                 (int)    current: 0 ");
            Console.WriteLine(" --- Transaction Data ---");
            Console.WriteLine("10) Last Deposit Amount (double) current: 0.000 OMR");
            Console.WriteLine("11) Last Withdrawal     (double) current: 0.000 OMR");
            Console.WriteLine("12) Annual Interest Rate(double) current:0.000  [e.g. 0.035 = 3.5%]");
            Console.WriteLine("13) Avg Monthly Balance (double) current: 0.000 OMR ");
            Console.WriteLine("0) Setup complete - Launch Main Menu");

            int option = 0;
            while (option != -1)
            {
                Console.Write("   Select option: ");
                int option1 = int.Parse(Console.ReadLine());

                switch (option1)
                {
                    // set accunt number 
                    case 1:
                        Console.WriteLine("Enter account number: ");
                        accountNumber = int.Parse(Console.ReadLine());
                        Console.WriteLine("Account number set to: " + accountNumber);
                        break;
                    // Set holder name
                    case 2:
                        Console.WriteLine("Enter holder name: ");
                        holderName = Console.ReadLine();
                        Console.WriteLine("Holder name set to: " + holderName);
                        break;

                    // Set balance
                    case 3:
                        Console.WriteLine("Enter balance (OMR): ");
                        balance = double.Parse(Console.ReadLine());
                        Console.WriteLine("Balance set to: " + balance.ToString("0.000") + " OMR");
                        break;

                    // Set account active status
                    case 4:
                        Console.WriteLine("Enter 1 for Yes / 0 for No: ");
                        isActive = int.Parse(Console.ReadLine()) == 1;
                        Console.WriteLine("Account active: " + isActive);
                        break;

                    // Set account type
                    case 5:
                        Console.WriteLine("Enter account type (S/C/F): ");
                        accountType = char.Parse(Console.ReadLine());
                        Console.WriteLine("Account type set to: " + accountType);
                        break;

                    // Set employment status
                    case 6:
                        Console.WriteLine("Enter 1 for Yes / 0 for No: ");
                        isEmployed = int.Parse(Console.ReadLine()) == 1;
                        Console.WriteLine("Employment status: " + isEmployed);
                        break;

                    // Set monthly salary
                    case 7:
                        Console.WriteLine("Enter monthly salary: ");
                        salary = double.Parse(Console.ReadLine());
                        Console.WriteLine("Monthly salary set to: " + salary.ToString("0.000") + " OMR");
                        break;

                    // Set credit score
                    case 8:
                        Console.WriteLine("Enter credit score: ");
                        creditScore = int.Parse(Console.ReadLine());
                        Console.WriteLine("Credit score set to: " + creditScore);
                        break;

                    // Set age
                    case 9:
                        Console.WriteLine("\nEnter age: ");
                        age = int.Parse(Console.ReadLine());
                        Console.WriteLine("Age set to: " + age);
                        break;

                    // Set last deposit amount
                    case 10:
                        Console.WriteLine("\nEnter last deposit amount: ");
                        deposit = double.Parse(Console.ReadLine());
                        Console.WriteLine("Last deposit set to: " + deposit.ToString("0.000") + " OMR");
                        break;

                    // Set last withdrawal amount
                    case 11:
                        Console.WriteLine("Enter last withdrawal amount: ");
                        withdrawal = double.Parse(Console.ReadLine());
                        Console.WriteLine("Last withdrawal set to: " + withdrawal.ToString("0.000") + " OMR");
                        break;

                    // Set annual interest rate
                    case 12:
                        Console.WriteLine("Enter annual interest rate: ");
                        annualRate = double.Parse(Console.ReadLine());
                        Console.WriteLine("Interest rate set to: " + annualRate);
                        break;

                    // Set average monthly balance
                    case 13:
                        Console.WriteLine("Enter average monthly balance: ");
                        avgBalance = double.Parse(Console.ReadLine());
                        Console.WriteLine("Average monthly balance set to: " + avgBalance.ToString("0.000") + " OMR");
                        break;

                    // Exit
                    case 0:
                        Console.WriteLine("Setup complete. Launching Main Menu...");
                        break;

                    // Invalid option
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }

            }
           




























        }
        
    }
}
