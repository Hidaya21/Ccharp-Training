using System.Numerics;
using System.Xml.Linq;

namespace Clinic_Management_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ── REGION 1: System Storage ─────────────────────────────────────
            // Capacity constants
            const int MAX_PATIENTS = 3;
            const int MAX_DOCTORS = 2;
            const int MAX_APPOINTMENTS = 3;
            // Patient slots
            string p1Name = ""; int p1Age = 0; string p1Phone = ""; bool p1Active = false;
            string p2Name = ""; int p2Age = 0; string p2Phone = ""; bool p2Active = false;
            string p3Name = ""; int p3Age = 0; string p3Phone = ""; bool p3Active = false;
            int patientCount = 0;
            // Doctor slots
            string d1Name = ""; string d1Spec = ""; double d1Fee = 0; bool d1Active = false;
            string d2Name = ""; string d2Spec = ""; double d2Fee = 0; bool d2Active = false;
            int doctorCount = 0;
            // Appointment slots
            string a1Patient = ""; string a1Doctor = ""; string a1Date = ""; string a1Status =
            ""; bool a1Active = false;
            string a2Patient = ""; string a2Doctor = ""; string a2Date = ""; string a2Status =
            ""; bool a2Active = false;
            string a3Patient = ""; string a3Doctor = ""; string a3Date = ""; string a3Status =
            ""; bool a3Active = false;
            int appointmentCount = 0;


            //==================================================================================================
            //Main Menu
            bool exit = false;
            while (exit != true)
            {
                Console.WriteLine("============================ ");
                Console.WriteLine("CLINIC MANAGEMENT SYSTEM ");
                Console.WriteLine("============================ ");
                Console.WriteLine("1. Patient Management ");
                Console.WriteLine("2. Doctor Management ");
                Console.WriteLine("3. Appointment Management ");
                Console.WriteLine("0. Exit ");
                Console.WriteLine("============================ ");
                Console.Write("Enter your choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                //==================================================================================================
                switch (choice)
                {
                    case 1:
                        bool patientExit = false;
                        while (patientExit != true)
                        {
                            Console.WriteLine("============================ ");
                            Console.WriteLine("  PATIENT MANAGEMENT  ");
                            Console.WriteLine("============================ ");
                            Console.WriteLine("1. Add New Patient ");
                            Console.WriteLine("2. Display All Patients ");
                            Console.WriteLine("3. Update Patient Phone");
                            Console.WriteLine("4. Delete Patient ");
                            Console.WriteLine("0. Back to Main Menu ");
                            Console.WriteLine("============================ ");
                            Console.Write("Enter your choice: ");
                            int patientChoice = Convert.ToInt32(Console.ReadLine());
                            switch (patientChoice)
                            {
                                //ADD Patient
                                case 1:
                                    if (patientCount == MAX_PATIENTS)
                                    {
                                        Console.Write("Clinic is full. Cannot add more patients.");
                                        return;
                                    }
                                    Console.Write("Enter your name: ");
                                    string name = Console.ReadLine();
                                    if (name == "")
                                    {
                                        Console.Write("error and stop!");
                                        return;
                                    }

                                    Console.Write("Enter your age: ");
                                    int age = Convert.ToInt32(Console.ReadLine());
                                    if (age < 1 || age > 120)
                                    {
                                        Console.Write("error and stop!");
                                        return;
                                    }
                                    Console.Write("Enter your phone: ");
                                    string phone = Console.ReadLine();


                                    if (!p1Active)
                                    {
                                        p1Name = name;
                                        p1Age = age;
                                        p1Phone = phone;
                                        p1Active = true;
                                    }
                                    else if (!p2Active)
                                    {
                                        p2Name = name;
                                        p2Age = age;
                                        p2Phone = phone;
                                        p2Active = true;

                                    }
                                    else if (!p3Active)
                                    {
                                        p3Name = name;
                                        p3Age = age;
                                        p3Phone = phone;
                                        p3Active = true;
                                    }
                                    patientCount++;
                                    Console.Write("Patient added successfully");
                                    break;

                                case 2:
                                    if (patientCount == 0)
                                    {
                                        Console.Write("No patients registered");
                                        return;
                                    }
                                    int displayNum = 1;
                                    if (p1Active)
                                    {
                                        Console.WriteLine("Patient #" + displayNum);
                                        Console.WriteLine("name: " + p1Name + "age:" + p1Age + "phone" + p1Phone);
                                        displayNum++;
                                    }
                                    if (p2Active)
                                    {
                                        Console.WriteLine("Patient #" + displayNum);
                                        Console.WriteLine("name: " + p2Name + "age:" + p2Age + "phone" + p2Phone);
                                        displayNum++;
                                    }
                                    if (p3Active)
                                    {
                                        Console.WriteLine("Patient #" + displayNum);
                                        Console.WriteLine("name: " + p3Name + "age:" + p3Age + "phone" + p3Phone);
                                        displayNum++;
                                    }
                                    break;

                                case 3:
                                    Console.Write("Enter patient name: ");
                                    string patientName = Console.ReadLine();
                                    if (p1Active && p1Name == patientName)
                                    {
                                        Console.Write("Enter new phone number: ");
                                        string newPhone = Console.ReadLine();
                                        p1Phone = newPhone;
                                        Console.Write("update. ");
                                    }
                                    else if (p2Active && p2Name == patientName)
                                    {
                                        Console.Write("Enter new phone number: ");
                                        string newPhone = Console.ReadLine();
                                        p2Phone = newPhone;
                                        Console.Write("update. ");
                                    }
                                    else if (p3Active && p3Name == patientName)
                                    {
                                        Console.Write("Enter new phone number: ");
                                        string newPhone = Console.ReadLine();
                                        p3Phone = newPhone;
                                        Console.Write("update. ");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Patient not found.");
                                    }
                                    break;

                                case 4:
                                    Console.Write("Enter patient name: ");
                                    string pName = Console.ReadLine();
                                    if (p1Active && p1Name == pName)
                                    {
                                        patientCount--;
                                        Console.WriteLine("Patient deleted.");
                                    }
                                    else if (p2Active && p2Name == pName)
                                    {
                                        patientCount--;
                                        Console.WriteLine("Patient deleted.");
                                    }
                                    else if (p3Active && p3Name == pName)
                                    {
                                        patientCount--;
                                        Console.WriteLine("Patient deleted.");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Patient not found.");
                                    }

                                    break;
                                case 0:
                                    Console.WriteLine("Back to Main Menu ");
                                    exit = true;
                                    break;
                                default:
                                    Console.Write(" do NOT exit the program ");
                                    break;
                            }
                            Console.Write(" press any key to countinue...  ");
                            Console.ReadLine();
                            Console.Clear();
                        }
                        break;

                    //==================================================================================================
                    case 2:
                        bool doctortExit = false;
                        while (doctortExit != true)
                        {
                            Console.WriteLine("============================ ");
                            Console.WriteLine("   DOCTOR MANAGEMENT  ");
                            Console.WriteLine("============================ ");
                            Console.WriteLine("1.Add New Doctor ");
                            Console.WriteLine("2. Display All Doctors ");
                            Console.WriteLine("3. Update Consultation Fee ");
                            Console.WriteLine("4. Delete Doctor ");
                            Console.WriteLine("0. Back to Main Menu ");
                            Console.WriteLine("============================ ");
                            Console.Write("Enter your choice: ");
                            int doctorChoice = Convert.ToInt32(Console.ReadLine());
                            switch (doctorChoice)
                            {
                                case 1:
                                    if (doctorCount == MAX_DOCTORS)
                                    {
                                        Console.Write(" No available doctor slots ");
                                        return;
                                    }
                                    Console.Write("Enter doctor name: ");
                                    string name = Console.ReadLine();
                                    if (name == "")
                                    {
                                        Console.WriteLine("error and stop!");
                                        return;
                                    }
                                    Console.Write("Enter specialization: ");
                                    string specialization = Console.ReadLine();
                                    if (specialization == "")
                                    {
                                        Console.WriteLine("error and stop!");
                                        return;
                                    }
                                    Console.Write("Enter fee: ");
                                    double fee = Convert.ToDouble(Console.ReadLine());      
                                    if (fee < 0)
                                    {
                                        Console.WriteLine("error and stop!");
                                        return;
                                    }
                                    if (!d1Active)
                                    {
                                        d1Name = name;
                                        d1Spec = specialization;
                                        d1Fee = fee;
                                        d1Active = true;
                                    }
                                    else if (!d2Active)
                                    {
                                        d2Name = name;
                                        d2Spec = specialization;
                                        d2Fee = fee;
                                        d2Active = true;
                                    }
                                    doctorCount++;

                                    Console.WriteLine("Doctor added successfully.");

                                    break;
                                case 2:
                                    if(doctorCount == 0)
                                    {
                                        Console.WriteLine("No doctors registered.");
                                    }
                                    if (d1Active)
                                    {
                                        Console.WriteLine(d1Name, d1Spec, d1Fee);
                                    }
                                    if (d2Active)
                                    {
                                        Console.WriteLine(d2Name, d2Spec, d2Fee);

                                    }
                                        break;
                                case 3:
                                    Console.Write("Enter doctor name to update fee: ");
                                    string updateName = Console.ReadLine();                    
                                    if (d1Active && d1Name == updateName)
                                    {
                                        Console.Write("Enter new fee: ");
                                        double newFee = Convert.ToDouble(Console.ReadLine());                        
                                        if (newFee < 0)
                                        {
                                            Console.WriteLine("error and stop!");
                                            return;
                                        }
                                        d1Fee = newFee;
                                        Console.WriteLine("Fee updated.");
                                    }
                                    else if (d2Active && d2Name == updateName)
                                    {
                                        Console.Write("Enter new fee: ");
                                        double newFee = Convert.ToDouble(Console.ReadLine());
                                        if (newFee < 0)
                                        {
                                            Console.WriteLine("error and stop!");
                                            return;
                                        }
                                        d2Fee = newFee;
                                        Console.WriteLine("Fee updated.");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Doctor not found.");
                                    }
                                    break;

                                case 4:
                                    Console.Write("Enter doctor name to delete: ");
                                    string deleteName = Console.ReadLine();
                                    if (d1Active && d1Name == deleteName)
                                    {
                                        doctorCount--;
                                        Console.WriteLine("Doctor removed.");
                                    }
                                    else if (d2Active && d2Name == deleteName)
                                    {
                                       
                                        doctorCount--;
                                        Console.WriteLine("Doctor removed.");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Doctor not found.");
                                    }

                                    break;
                                case 0:
                                    Console.WriteLine("Back to Main Menu ");
                                    exit = true;
                                    break;
                                default:
                                    Console.Write(" do NOT exit the program ");
                                    break;
                            }
                        }
                        break;

                    //==================================================================================================
                    case 3:
                        bool appointmentExit = false;
                        while (appointmentExit != true)
                        {
                            Console.WriteLine("============================ ");
                            Console.WriteLine("  APPOINTMENT MANAGEMENT   ");
                            Console.WriteLine("============================ ");
                            Console.WriteLine("1. Book New Appointment ");
                            Console.WriteLine("2. Display All Appointments ");
                            Console.WriteLine("3. Update Appointment Status ");
                            Console.WriteLine("4. Cancel Appointment ");
                            Console.WriteLine("0. Back to Main Menu ");
                            Console.WriteLine("============================ ");
                            Console.Write("Enter your choice: ");
                            int appointmentChoice = Convert.ToInt32(Console.ReadLine());
                            switch (appointmentChoice)
                            {
                                case 1:
                                    break;
                                case 2:
                                    break;
                                case 3:
                                    break;
                                case 4:
                                    break;
                                case 0:
                                    Console.WriteLine("Back to Main Menu ");
                                    exit = true;
                                    break;
                                default:
                                    Console.Write(" do NOT exit the program ");
                                    break;
                            }

                        }
                        break;

                    //==================================================================================================
                    case 0:
                        Console.WriteLine("Back to Main Menu ");
                        exit = true;
                        break;
                    default:
                        Console.Write(" do NOT exit the program ");
                        break;
                }
                Console.Write(" press any key to countinue...  ");
                Console.ReadLine();
                Console.Clear();
            }


        }
    }
}
