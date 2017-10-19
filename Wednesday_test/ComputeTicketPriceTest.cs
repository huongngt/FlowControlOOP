using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wednesday_Flow_String;

namespace Wednesday_test
{
    [TestClass]
    public class ComputeTicketPriceTest
    {
        [TestMethod]
        public void PrintTypeCheck()
        {
            CinemaTicket CinemaTicket = new CinemaTicket();
            CinemaTicket.AddTicket(18);
            CinemaTicket.AddTicket(50);
            CinemaTicket.AddTicket(65);
            CinemaTicket.AddTicket(2);
            CinemaTicket.AddTicket(101);

            Assert.AreEqual("Kids deal: 80kr", CinemaTicket.ComputeType(CinemaTicket.tickets[0]));
            Assert.AreEqual("Standard price: 120kr", CinemaTicket.ComputeType(CinemaTicket.tickets[1]));
            Assert.AreEqual("Senior Citizen Discount: 90kr", CinemaTicket.ComputeType(CinemaTicket.tickets[2]));
            Assert.AreEqual("Free ticket", CinemaTicket.ComputeType(CinemaTicket.tickets[3]));
            Assert.AreEqual("Free ticket", CinemaTicket.ComputeType(CinemaTicket.tickets[4]));
        }

        [TestMethod]
        public void ComputePriceCheck()
        {
            CinemaTicket CinemaTicket = new CinemaTicket();
            CinemaTicket.AddTicket(18);
            CinemaTicket.AddTicket(50);
            CinemaTicket.AddTicket(65);
            CinemaTicket.AddTicket(2);
            CinemaTicket.AddTicket(101);

            Assert.AreEqual(80, CinemaTicket.ComputePrice(CinemaTicket.tickets[0]));
            Assert.AreEqual(120, CinemaTicket.ComputePrice(CinemaTicket.tickets[1]));
            Assert.AreEqual(90, CinemaTicket.ComputePrice(CinemaTicket.tickets[2]));
            Assert.AreEqual(0, CinemaTicket.ComputePrice(CinemaTicket.tickets[3]));
            Assert.AreEqual(0, CinemaTicket.ComputePrice(CinemaTicket.tickets[4]));
            Assert.AreEqual(290, CinemaTicket.ComputeSum());
        }

    }
}
