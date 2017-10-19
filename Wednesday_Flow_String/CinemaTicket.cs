using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wednesday_Flow_String
{
    public class CinemaTicket
    {
        public int age;
        public List<int> tickets;

        public CinemaTicket()
        {
            tickets = new List<int>();

        }

        public int ComputePrice(int age)
        {
            int price = 0;
            if (age <= 2 || age > 100)
            {
                price = 0;
            }
            else if (age < 20)
            {
                price = 80;
            }
            else if (age > 64)
            {
                price = 90;
            }
            else
            {
                price = 120;
            }
            return price;
        }

        public string ComputeType(int age)
        {
            string type = null;
            if (age <= 2 || age > 100)
            {
                type = "Free ticket";
            }
            else if (age < 20)
            {
                type = "Kids deal: 80kr";
            }
            else if (age > 64)
            {
                type = "Senior Citizen Discount: 90kr";
            }
            else
            {
                type = "Standard price: 120kr";
            }
            return type;
        }

        public void AddTicket(int age)
        {
            
            tickets.Add(age);
            
        }

        public int ComputeSum()
        {
            int sum = 0;
            foreach (int n in tickets)
            {
                sum += ComputePrice(n);
            }

            return sum;
        }

        public void PrintType()
        {
            foreach (var n in tickets)
            {
                Console.WriteLine(ComputeType(n));
            }
        }

    }
}
