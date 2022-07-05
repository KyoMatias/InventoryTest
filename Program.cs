using System;
using System.Diagnostics;
using System.Text;
using System.IO;
using System.Threading;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;


namespace Test_code
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            bool launchMenu = true;
            while (launchMenu)
            {
                launchMenu = initmenu();
            }
        }


        public static bool initmenu()
        {
            Console.Title = "Initiation";
            Console.CursorVisible = false;
            Console.SetCursorPosition(1, 1);

            for (int i = 0; i < 100; i++)
            {
                Console.Write("[");
                for (int y = 0; y < i; y++)
                {
                    //Rename "pb" to "progBar" later or else
                    //string pb = "\u2551";
                    string pb = "\u2588";
                    Console.Write(pb);
                }
                Console.Write("]" + (i + 1 + " / 100"));
                Console.SetCursorPosition(1, 1);
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("[Starting Program...]");
                System.Threading.Thread.Sleep(25);

            }



            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n");
            Console.WriteLine("\nSTATUS");

            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("\nMENU INTERFACE: ");
            Thread.Sleep(500);
            Success();
            Thread.Sleep(50);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("\nINVENTORY: ");
            Thread.Sleep(500);
            WIP();
            Thread.Sleep(50);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("\nCREDENTIALS: ");
            Thread.Sleep(500);
            Success();
            Thread.Sleep(50);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("\nCONSOLE: ");
            Thread.Sleep(500);
            Success();
            Thread.Sleep(50);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("\nIMPORT: ");
            Thread.Sleep(500);
            Failed();
            Thread.Sleep(50);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("\nSAVEFILE: ");
            Thread.Sleep(500);
            Warning();

            Thread.Sleep(2000);

            Console.Clear();
            return Logic();

        }


        public static void Failed()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("FAILED");
        }

        public static void Warning()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("REVIEW");
        }
        public static void Success()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("PASSED");
        }
        public static void WIP()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("ONGOING");
        }

        public static bool Logic()
        {
            Console.Title = "Main Software";
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("                                                \u2588 \u2588\u2588\u2588\u2588\u2588\u2588\u2588\u2588\u2588\u2588\u2588\u2588\u2588\u2588\u2588\u2588\u2588\u2588\u2588\u2588\u2588\u2588\u2588 \u2588");
            Console.WriteLine("                                                \u2588 Welcome to the software!\u2588");
            Console.WriteLine("                                                \u2588 \u2588\u2588\u2588\u2588\u2588\u2588\u2588\u2588\u2588\u2588\u2588\u2588\u2588\u2588\u2588\u2588\u2588\u2588\u2588\u2588\u2588\u2588\u2588 \u2588");
            Console.WriteLine("                                                  1> Open the Inventory");
            Console.WriteLine("                                                  2> Open contents");
            Console.WriteLine("                                                  3> Options");
            Console.WriteLine("                                                  4> Close the Program");
            Console.WriteLine("                                                  5> Developer Menu");
            Console.WriteLine("                                                  6> System Check");

            string input = Console.ReadLine();
            Console.SetCursorPosition((Console.WindowWidth - input.Length) / 2, Console.CursorTop);
            switch (input)
            {
                case "1":
                    return RunText();
                case "2":
                    string contents = File.ReadAllText(@"D:\Codes\Softwares\sw.txt");
                    Console.WriteLine("This are the Contents of the File:");
                    Console.WriteLine(contents);
                    Console.ReadKey();
                    Console.Clear();
                    return Logic();
                case "3":
                    Console.Clear();
                    Options();
                    return Logic();
                case "4":
                    Environment.Exit(0);
                    return false;
                case "5":
                    Console.Clear();
                    PlayVideo();
                    return Logic();
                case "6":
                    Console.Clear();
                    SystemCheck();
                    Console.ReadKey();
                    Console.Clear();
                    return Logic();
                    break;
            }
            return false;
        }

        public static void MenuStatus()
        {
            
            NodeStatus menuStatus = new NodeStatus();

            menuStatus.setStatus("review");
            menuStatus.getStatus();
            
        }

        public static void InventoryStatus()
        {
            NodeStatus inventoryStatus = new NodeStatus();

            inventoryStatus.setStatus("true");
            inventoryStatus.getStatus();
        }

        public static void CredentialStatus()
        {
            NodeStatus credentialStatus = new NodeStatus();

            credentialStatus.setStatus("review");
            credentialStatus.getStatus();
        }
        public static void ConsoleStatus()
        {
            NodeStatus consoleStatus = new NodeStatus();

            consoleStatus.setStatus("true");
            consoleStatus.getStatus();
        }
        public static void SystemCheck() {

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n");
            Console.WriteLine("\n SYSTEM STATUS");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("\nMENU INTERFACE: ");
            Thread.Sleep(500);
            MenuStatus();
            Thread.Sleep(20);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("\nINVENTORY LIST: ");
            Thread.Sleep(500);
            InventoryStatus();
            Thread.Sleep(20);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("\nCREDENTIAL: ");
            Thread.Sleep(500);
            CredentialStatus();
            Thread.Sleep(20);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("\nCONSOLE STATUS: ");
            Thread.Sleep(500);
            ConsoleStatus();

        }
        public static bool RunText()
        {
            Console.Title = "Opening File....";
            Process software = new Process();
            software.StartInfo.FileName = @"D:\Codes\Inventory\Inventory\bin\Debug\inventory.exe";
            software.StartInfo.Arguments = "-v -s -a";
            software.Start();
            Console.Clear();
            return Logic();
        }
        public static bool PlayVideo()
        {
            Console.Title = "Developer Menu";
            Console.WriteLine("Select an Option");

            Console.WriteLine("1 > Change Credentials");
            Console.WriteLine("2 > Access Inventory List");
            Console.WriteLine("3 > Exit");

            string devInput = Console.ReadLine();
            switch (devInput)
            {
                case "1":
                    Console.Clear();
                    CredentialsMain();

                    return false;
                case "2":
                    Console.Clear();
                    InventoryLoginMain();
                    return false;

                case "3":
                    Console.Clear();
                    Logic();

                    break;
            }
            return false;
        }
        public static void Options()
        {
            Console.Title = "HELLO?????";
            Console.WriteLine("CHECKMATE, ASSHOLE!!!!");
            Console.ReadKey();
            Console.Clear();
        }

        public static void InventoryLoginMain()
        {
            string invenAdminInput, invenAdminPass;
            string invenAdminMasterInput, invenAdminMasterPass;

            invenAdminMasterInput = "InventoryAdmin";
            invenAdminMasterPass = "InventoryPassword";

            Console.WriteLine("Welcome to the Inventory Access Menu"); ;

            Console.WriteLine("\n*Type BACK to return to Developer Options Menu*");
            Console.WriteLine();
            Console.Write("Please Login using the administrator Username:");
            invenAdminInput = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("Please Login Using the Administrator Password: ");
            invenAdminPass = Console.ReadLine();

            if (invenAdminInput == invenAdminMasterInput && invenAdminPass == invenAdminMasterPass)
            {
                Console.Clear();
                Console.WriteLine("You Have Been Granted Access!");
                Thread.Sleep(3000);
                Console.WriteLine("Opening Inventory File ...");
                Thread.Sleep(2000);
                Process Inventory = new Process();
                Inventory.StartInfo.FileName = @"D:\Codes\Folders\InventoryMain.txt";
                Inventory.StartInfo.Arguments = "-v -s -a";
                Inventory.Start();
                Console.Clear();
                InventoryLoginMain();
            }
            else if (invenAdminInput == "back")
            {
                Console.Clear();
                InventoryLoginMain();
            }

            else if (invenAdminInput == "display")
            {
                Console.Clear();
                InventoryConsoleDisplay();
                Console.ReadKey();
                Console.Clear();
            }
            else
            {
                Console.WriteLine("ACCESS DENIED");
                Thread.Sleep(3000);
                Console.WriteLine("Returning To Menu...");
                Thread.Sleep(1000);
                Console.Clear();
                Logic();
            }


        }
        public static bool CredentialsMain()
        {
            Console.WriteLine("Type ADMIN to change the admin credentials");
            Console.WriteLine("Type PASS to change the password credentials");
            Console.WriteLine("Type DONE to go back to menu");
            string credInput = Console.ReadLine();

            switch (credInput)
            {
                case "admin":
                    string adminOld = File.ReadAllText(@"D:\Codes\Softwares\cred\ADMINMAIN.txt");
                    Console.WriteLine("The Old Admin Name is : {0}", adminOld);
                    Console.WriteLine("");
                    Console.Write("Type the New Name for Admin: ");
                    string adminNew = Console.ReadLine();
                    adminOld = adminNew.Replace(adminOld, adminNew);
                    File.WriteAllText(@"D:\Codes\Softwares\cred\ADMINMAIN.txt", adminNew);
                    Console.WriteLine("Successfully changed old Admin Credential to ({0})", adminNew);
                    Console.ReadKey();
                    Console.Clear();
                    return CredentialsMain();


                case "pass":
                    string passOld = File.ReadAllText(@"D:\Codes\Softwares\cred\PASSWORDMAIN.txt");
                    Console.WriteLine("The Password is :  {0}", passOld);
                    Console.WriteLine("");
                    Console.WriteLine("Type the new password: ");
                    string passNew = Console.ReadLine();
                    passOld = passNew.Replace(passOld, passNew);
                    File.WriteAllText(@"D:\Codes\Softwares\cred\PASSWORDMAIN.txt", passNew);
                    Console.WriteLine("Successfully changed old Password Credential to ({0})", passNew);
                    Console.ReadKey();
                    Console.Clear();
                    return CredentialsMain();

                case "done":
                    Console.Clear();
                    return CredentialsMain();
                    break;
            }
            return false;
        }

        public static void InventoryConsoleDisplay()
        {

            Console.WriteLine("Displaying the Inventory");

            List<CPU> cpuAMDItem = new List<CPU>();
            cpuAMDItem.Add(new CPU("cpuR_1", "AMD Athlon", "200GE", "Php 3995"));
            cpuAMDItem.Add(new CPU("cpuR_2", "AMD Athlon", "3000G", "Php 4350"));
            cpuAMDItem.Add(new CPU("cpuR_3", "AMD Athlon", "A6 9500", "Php 2900"));
            cpuAMDItem.Add(new CPU("cpuR_4", "AMD Athlon", "A8 9600", "Php 3450"));
            cpuAMDItem.Add(new CPU("cpuR_5", "AMD Athlon", "A10 9700MPK", "Php 3750"));
            cpuAMDItem.Add(new CPU("cpuR_6", "AMD Athlon", "A10 9700", "Php 4100"));

            List<CPU> cpuIntelItem = new List<CPU>();
            cpuIntelItem.Add(new CPU("cpuI_1", "Intel Pentium", "G6400", "Php 3700"));
            cpuIntelItem.Add(new CPU("cpuI_2", "Intel Pentium", "G6405", "Php 3900"));
            cpuIntelItem.Add(new CPU("cpuI_3", "Intel i3", "10100F", "Php 4800"));
            cpuIntelItem.Add(new CPU("cpuI_4", "Intel i3", "10100 oem", "Php 6900"));
            cpuIntelItem.Add(new CPU("cpuI_5", "Intel i3", "10100", "Php 7250"));
            cpuIntelItem.Add(new CPU("cpuI_6", "Intel i5", "10239", "Php 4500"));


            Console.WriteLine("\nINTEL CPU: ");
            {


                cpuIntelItem.ForEach(delegate (CPU CPU)
                {
                    Console.WriteLine("ID: " + CPU.cpu_id + " Model Name: " + CPU.cpu_name + " Model Version :" + CPU.cpu_version + " Item Price :" + CPU.cpu_price);
                });
            }
            Console.WriteLine("\nINTEL AMD: ");
            {
                cpuAMDItem.ForEach(delegate (CPU CPU)
                {
                    Console.WriteLine("ID: " + CPU.cpu_id + " Model Name: " + CPU.cpu_name + " Model Version :" + CPU.cpu_version + " Item Price :" + CPU.cpu_price);
                });
            }

        }

        public static void TestInvetory()
        {
            ArrayList inventoryList = new ArrayList();
            string readIntelList = File.ReadAllText(@"D:\Codes\Folders\CPU\intel.txt");
            string readAMDList = File.ReadAllText(@"D:\Codes\Folders\CPU\amd.txt");

            string cpu_IntelLineup = readIntelList;
            string cpu_AMDLineup = readAMDList;

            string[] intel = cpu_IntelLineup.Split(',');
            string[] amd = cpu_AMDLineup.Split(',');


            foreach (var sub in intel)
            {
                Console.WriteLine($"CPU: {sub}");
            }

            foreach (var sub in amd)
            {
                Console.WriteLine($"CPU: {sub}");
            }

            foreach (var items in inventoryList)
            {
                Console.Write(items);
            }
        }
        class CPU
        {
            public string cpu_id;
            public string cpu_name;
            public string cpu_version;
            public string cpu_price;

            public CPU(string cpu_id, string cpu_name, string cpu_version, string cpu_price)
            {
                this.cpu_id = cpu_id;
                this.cpu_name = cpu_name;
                this.cpu_version = cpu_version;
                this.cpu_price = cpu_price;
            }
        }
        class NodeStatus
        {
            private string Methodstatus;
            public void setStatus(string Methodstatus)
            {
                this.Methodstatus = Methodstatus;
            }
            public string getStatus()
            {     
                    switch (Methodstatus)
                {
                    case "true":
                        Success();
                        break;


                    case "false":
                        Failed();
                        break;


                    case "wip":
                        WIP();
                        break;


                    case "review":
                        Warning();
                        break;


                    default:
                        Console.Write("NULL");

                        break;
                }
                return Methodstatus;
            }

   
                }
            }
        }

            



        
    

    

        
    


            //Logs
            //Finished creating inventory access menu [/]
            //Create the Invetory import system [].
            //SITREP Rewrite the Item add list [].
            //SITREP Created a draft testing system[].
    

    
