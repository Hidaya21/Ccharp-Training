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
            char accountType= '-';
            bool isEmployed = false;
            double salary= 0.0;
            int creditScore = 0;
            int age = 0;
            double deposit = 0.0;
            double withdrawal = 0.0;
            double annualRate = 0.0;
            double avgBalance = 0.0;
            Console.WriteLine("1)  Account Number      (int)    current: 0 ");
            Console.WriteLine("2)  Holder Name         (string) current: [not set]" );
            Console.WriteLine("3)  Balance             (double) current: 0.000 OMR " );
            Console.WriteLine("4)  Account Active?     (bool)   current: false   [enter 1=yes / 0=no] " );
            Console.WriteLine("5)  Account Type        (char)   current:   [enter S / C / F]");
            Console.WriteLine(" --- Customer Profile ---");
            Console.WriteLine("6)  Employed?           (bool)   current: false [enter 1=yes / 0=no]");
            Console.WriteLine("7)  Monthly Salary      (double) current: 0.000 OMR " );
            Console.WriteLine("8)  Credit Score        (int)    current: 0 " );
            Console.WriteLine("9)  Age                 (int)    current: 0 " );
            Console.WriteLine(" --- Transaction Data ---");
            Console.WriteLine("10) Last Deposit Amount (double) current: 0.000 OMR" );
            Console.WriteLine("11) Last Withdrawal     (double) current: 0.000 OMR" );
            Console.WriteLine("12) Annual Interest Rate(double) current:0.000  [e.g. 0.035 = 3.5%]");
            Console.WriteLine("13) Avg Monthly Balance (double) current: 0.000 OMR ");
            Console.WriteLine("0) Setup complete - Launch Main Menu");

           
           








        }
    }
}
