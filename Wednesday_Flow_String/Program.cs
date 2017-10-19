using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wednesday_Flow_String
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu MainMenu = new Menu();
            MainMenu.Description = "Main Menu:";
            MainMenu.AddMenuItem("1", "Enter 1 to print the price of cinema ticket", new Action(() => { CalculateCinemaTicketPrice(); }));
            MainMenu.AddMenuItem("2", "Enter 2 to print a string ten times", new Action(() => { PrintTenString(); }));
            MainMenu.AddMenuItem("3", "Enter 3 to find the third word in a string", new Action(() => { PrintThirdWord(); }));
            MainMenu.AddMenuItem("0", "Enter 0 to Exit", new Action(() => { Close(); }));
            bool DisplayMenu = true;
            while (DisplayMenu)
            {
                MainMenu.Display();
                string input = Console.ReadLine();
                if (input == "0") DisplayMenu = false;
                MainMenu.ExecuteEntry(input);
            }            

        }


        private static void CalculateCinemaTicketPrice()
        {
            Console.Clear();
            Console.WriteLine("This program will print out your cinema price");
            CinemaTicket tickets = new CinemaTicket();
            InputTickets(tickets);
            PrintTickets(tickets);
            Console.ReadLine();
        }

        private static void PrintTickets(CinemaTicket tickets)
        {
            Console.WriteLine("------------------");
            Console.WriteLine("Total price");
            tickets.PrintType();
            Console.WriteLine("Total: {0:C}",  tickets.ComputeSum());

        }

        private static void InputTickets(CinemaTicket tickets)
        {
            Console.Write("Number of person to buy:");
            try
            {
                int n = Int32.Parse(Console.ReadLine());
                for (int i = 0; i < n; i++)
                {
                    Console.Write("Please input the age of person " + (i + 1).ToString() + ":");
                    int age = Int32.Parse(Console.ReadLine());
                    tickets.AddTicket(age);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Something went wrong!");
                Console.WriteLine(ex.Message);
            }
        }

        private static void PrintThirdWord()
        {
            Console.Clear();
            Console.WriteLine("This program will print out the third word in your inputed string");
            Console.Write("Please input your string with more than 3 words:");
            string input = Console.ReadLine();
            StringManipulation str = new StringManipulation();
            str.MainString = input;            
            Console.WriteLine("The third words: " + str.FindThirdWord());
            Console.ReadLine();
        }

        private static void PrintTenString()
        {
            Console.Clear();
            Console.WriteLine("This program will print out your inputed string ten times");
            Console.Write("Please input your string:");
            string input = Console.ReadLine();
            StringManipulation str = new StringManipulation();
            str.MainString = input;
            str.PrintString();
        }

        private static void Close()
        {
            Console.WriteLine("Thank you and good bye");
            System.Threading.Thread.Sleep(500);
            return;
        }

    }
}
