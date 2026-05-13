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

            int option = -1;
            while (option != 0)
            {
                Console.Write("Select option: ");
                option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    // set accunt number 
                    case 1:
                        Console.Write("Enter account number: ");
                        accountNumber = int.Parse(Console.ReadLine());
                        Console.WriteLine("Account number set to: " + accountNumber);
                        break;
                    // Set holder name
                    case 2:
                        Console.Write("Enter holder name: ");
                        holderName = Console.ReadLine();
                        Console.WriteLine("Holder name set to: " + holderName);
                        break;

                    // Set balance
                    case 3:
                        Console.Write("Enter balance (OMR): ");
                        balance = double.Parse(Console.ReadLine());
                        Console.WriteLine("Balance set to: " + balance.ToString("0.000") + " OMR");
                        break;

                    // Set account active status
                    case 4:
                        Console.Write("Enter 1 for Yes / 0 for No: ");
                        isActive = int.Parse(Console.ReadLine()) == 1;
                        Console.WriteLine("Account active: " + isActive);
                        break;

                    // Set account type
                    case 5:
                        Console.Write("Enter account type (S/C/F): ");
                        accountType = char.Parse(Console.ReadLine());
                        Console.WriteLine("Account type set to: " + accountType);
                        break;

                    // Set employment status
                    case 6:
                        Console.Write("Enter 1 for Yes / 0 for No: ");
                        isEmployed = int.Parse(Console.ReadLine()) == 1;
                        Console.WriteLine("Employment status: " + isEmployed);
                        break;

                    // Set monthly salary
                    case 7:
                        Console.Write("Enter monthly salary: ");
                        salary = double.Parse(Console.ReadLine());
                        Console.WriteLine("Monthly salary set to: " + salary.ToString("0.000") + " OMR");
                        break;

                    // Set credit score
                    case 8:
                        Console.Write("Enter credit score: ");
                        creditScore = int.Parse(Console.ReadLine());
                        Console.WriteLine("Credit score set to: " + creditScore);
                        break;

                    // Set age
                    case 9:
                        Console.Write("\nEnter age: ");
                        age = int.Parse(Console.ReadLine());
                        Console.WriteLine("Age set to: " + age);
                        break;

                    // Set last deposit amount
                    case 10:
                        Console.Write("\nEnter last deposit amount: ");
                        deposit = double.Parse(Console.ReadLine());
                        Console.WriteLine("Last deposit set to: " + deposit.ToString("0.000") + " OMR");
                        break;

                    // Set last withdrawal amount
                    case 11:
                        Console.Write("Enter last withdrawal amount: ");
                        withdrawal = double.Parse(Console.ReadLine());
                        Console.WriteLine("Last withdrawal set to: " + withdrawal.ToString("0.000") + " OMR");
                        break;

                    // Set annual interest rate
                    case 12:
                        Console.Write("Enter annual interest rate: ");
                        annualRate = double.Parse(Console.ReadLine());
                        Console.WriteLine("Interest rate set to: " + annualRate);
                        break;

                    // Set average monthly balance
                    case 13:
                        Console.Write("Enter average monthly balance: ");
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

            }// end while loop
            /*
            NATIONAL BANK OF OMAN  —  Unified Banking System
            Task 1  →  System Setup (populate all shared variables first)
            MAIN MENU  (available after setup)
              1) ATM Services  →  Tasks  2,  3,  4,  5        
              2) Account Management  →  Tasks  6,  7,  8
              3) Loan Services   →  Tasks  9, 10, 11     
              4) Currency Exchange   →  Tasks 12, 13   
              5) Credit Card Portal  →  Tasks 14, 15  
              6) Branch Services     →  Tasks 16, 17, 18   
              7) Reports & Admin     →  Tasks 19, 20, 21   
             */

            Console.WriteLine(" === SYSTEM SETUP  —  Enter Account & Customer Data ===");
            Console.WriteLine("--- Account Profile --- ");
            Console.WriteLine(" ===== MAIN MENU =====  ");
            Console.WriteLine("  1) ATM Services       ");
            Console.WriteLine("  2) Account Management ");
            Console.WriteLine("  3) Loan Services      ");
            Console.WriteLine("  4) Currency Exchange  ");
            Console.WriteLine("  5) Credit Card Portal ");
            Console.WriteLine("  6) Branch Services    ");
            Console.WriteLine("  7) Reports & Admin    ");
            Console.WriteLine("  Enter your option:    ");
            int option1 = int.Parse(Console.ReadLine());
            switch (option1)
            {
                case 1:
                    Console.WriteLine(" == ATM SERVICES ==");
                    Console.WriteLine(" 1) Bank Info ");
                    Console.WriteLine(" 2) Branch Info ");
                    Console.WriteLine(" 3) Opening Hours");
                    Console.WriteLine(" 0) Back to Main Menu");
                    Console.WriteLine("Select: ");
                    int AtmOption = int.Parse(Console.ReadLine());
                    switch (AtmOption)
                    {
                        case 1:
                            Console.WriteLine("===== BANK INFO =====");
                            Console.WriteLine("Bank Name   : National Bank of Oman");
                            Console.WriteLine("Tagline     : Together We Prosper");
                            Console.WriteLine("Founded Year: 1973");
                            break;
                        case 2:
                            Console.WriteLine("===== BRANCH INFO =====");
                            Console.WriteLine("Branch Name : Muscat Main Branch");
                            Console.WriteLine("City        : Muscat");
                            Console.WriteLine("Address     : Sultan Qaboos Street");
                            break;
                        case 3:
                            Console.WriteLine("===== OPENING HOURS =====");
                            Console.WriteLine("Weekdays : 8:00 AM - 3:00 PM");
                            Console.WriteLine("Weekend  : Closed");
                            break;
                        case 0:
                            Console.WriteLine("Returning to Main Menu...");
                            break;
                        default:
                            Console.WriteLine("Invalid selection. Please try again.");
                            break;
                    }
                    break;
                case 2:
                    Console.WriteLine(" === VIEW ACCOUNT DATA === ");
                    Console.WriteLine(" Data loaded from system setup ");
                    Console.WriteLine(" 1) Account Number → " + accountNumber);
                    Console.WriteLine(" 2) Holder Name → " + holderName);
                    Console.WriteLine(" 3) Balance → " + balance);
                    Console.WriteLine(" 4) Account Status → "+ isActive);
                    Console.WriteLine(" 5) Account Type → " + accountType);
                    Console.WriteLine(" 0) Back ");
                    Console.WriteLine(" Select field: ");
                    int AccountOption = int.Parse(Console.ReadLine());
                    switch (AccountOption)
                    {
                        case 1:
                            Console.WriteLine(" 1) Account Number → " + accountNumber);
                            break;
                        case 2:
                            Console.WriteLine(" 2) Holder Name → " + holderName);
                            break;
                        case 3:
                            Console.WriteLine(" 3) Balance → " + balance);
                            break;
                        case 4:
                            Console.WriteLine(" 4) Account Status → " + isActive);
                            break;
                        case 5:
                            Console.WriteLine(" 5) Account Type → " + accountType);
                            break;
                        case 0:
                            Console.WriteLine("Returning to Main Menu...");
                            break;
                        default:
                            Console.WriteLine("Invalid selection. Please try again.");
                            break;
                    }

                    break;
                case 3:
                    const int CORRECT_PIN = 4821;
                    const int MAX_ATTEMPTS = 3;
                    
                    Console.WriteLine(" === AUTHENTICATION === ");
                    Console.WriteLine(" 1) Enter PIN ");
                    Console.WriteLine(" 2) Forgot PIN ");
                    Console.WriteLine(" 0) Back ");
                    
                    

                    while (option != 0) {
                        Console.WriteLine(" Select:  ");
                        int AuthOption = int.Parse(Console.ReadLine());
                        switch (AuthOption)
                        {
                           
                            case 1:
                            int attemps = 0;
                            bool accessGranted = false;
                                while (attemps < MAX_ATTEMPTS && !accessGranted)
                                {
                                    Console.WriteLine(" Enter 4 digits PIN: ");
                                    string PINOption = Console.ReadLine();
                                    //Check PIN length 
                                    if (PINOption.Length != 4)
                                    { Console.WriteLine("Invalid PIN format."); }
                                    else
                                    {
                                        int Pin = int.Parse(PINOption);
                                        //Check correct PIN
                                        if (Pin == CORRECT_PIN)
                                        {
                                            Console.WriteLine("Access granted. Welcome" + holderName);
                                            accessGranted = true;
                                        }

                                        else
                                        { Console.WriteLine("Incorrect PIN"); }
                                        attemps++;
                                    }
                                    if (!accessGranted)
                                    { 
                                        Console.WriteLine(" Maximum attemps reached! ");
                                    }
                                       
                                }

                                break;
                            case 2:
                                Console.WriteLine(" 'Please visit the nearest branch with your National ID.");
                                break;
                            case 0:
                                Console.WriteLine("Returning to Main Menu...");
                                break;
                            default:
                                Console.WriteLine("Invalid selection. Please try again.");
                                break;
                        }
                    }
            
                    break;
            }





























        }
        
    }
}
