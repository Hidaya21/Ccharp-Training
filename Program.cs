namespace BankingServices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //system setup (system storage)
            int accountNumber = 0;
            string olderName = "";
            double balance = 0.0;
            bool isActive = false;
            char accountType;
            bool isEmployed = false;
            double salary= 0.0;
            int creditScore = 0;
            int age = 0;
            double deposit = 0.0;
            double withdrawal = 0.0;
            double annualRate = 0.0;
            double avgBalance = 0.0;

            


            //Console.WriteLine(" === VIEW ACCOUNT DATA === ");
            //Console.WriteLine(" Data loaded from system setup ");
            //Console.WriteLine(" 1) Account Number → ");
            //Console.WriteLine(" 2) Holder Name → ");
            //Console.WriteLine(" 3) Balance → ");
            //Console.WriteLine(" 4) Account Status → ");
            //Console.WriteLine(" 5) Account Type → ");
            //Console.WriteLine(" 0) Back ");
            //Console.WriteLine(" Select field: ");


            //Console.WriteLine(" === AUTHENTICATION === ");
            //Console.WriteLine(" 1) Enter PIN ");
            //Console.WriteLine(" 2) Forgot PIN ");
            //Console.WriteLine(" 0) Back ");
            //Console.WriteLine(" Select:  ");

            //Console.WriteLine(" === PRINT RECEIPT === ");
            //Console.WriteLine(" 1) Short Receipt ");
            //Console.WriteLine(" 2) Detailed Receipt ");
            //Console.WriteLine(" 3) Balance Only ");
            //Console.WriteLine(" 0) Back ");
            //Console.WriteLine(" Select format: ");

            //Console.WriteLine("=== TRANSACTION CALCULATOR === ");
            //Console.WriteLine(" Using: balance=12,500.000  deposit=1,500.000  rate=3.5% ");
            //Console.WriteLine(" 1) Balance After Deposit ");
            //Console.WriteLine(" 2) Balance After Withdrawal ");
            //Console.WriteLine(" 3) Annual Interest Earned ");
            //Console.WriteLine(" 4) Net Balance Change ");
            //Console.WriteLine(" 0) Back ");
            //Console.WriteLine(" Select calculation:  ");

            //Console.WriteLine("=== ACCOUNT TYPES === ");
            //Console.WriteLine(" 1) Savings Account ");
            //Console.WriteLine(" 2) Current Account ");
            //Console.WriteLine(" 3) Fixed Deposit ");
            //Console.WriteLine(" 4) Junior Account ");
            //Console.WriteLine(" 0) Back ");
            //Console.WriteLine(" Select type: ");
            //Console.WriteLine(" Savings Account | Min: 100.000 OMR | Fee: ");
            //Console.WriteLine(" *** This is your account type *** ");
            //Console.WriteLine(" Can be opened at any branch. ");

            //Console.WriteLine("=== LOAN ELIGIBILITY === ");
            //Console.WriteLine(" Holder: Sara Al-Balushi  |  Salary: 850.000 OMR  |  Score: 710  |  Age: 3 ");
            //Console.WriteLine(" 1) Personal Loan  ");
            //Console.WriteLine(" 2) Car Loan ");
            //Console.WriteLine(" 3) Home Loan ");
            //Console.WriteLine(" 0) Back ");
            //Console.WriteLine(" Select type: ");





            //system options
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
            int option = int.Parse(Console.ReadLine());
            switch (option)
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
                            Console.WriteLine("\n===== BRANCH INFO =====");
                            Console.WriteLine("Branch Name : Muscat Main Branch");
                            Console.WriteLine("City        : Muscat");
                            Console.WriteLine("Address     : Sultan Qaboos Street");
                            break;
                        case 3:
                            Console.WriteLine("\n===== OPENING HOURS =====");
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
                    break;
            }
          


        }
    }
}
