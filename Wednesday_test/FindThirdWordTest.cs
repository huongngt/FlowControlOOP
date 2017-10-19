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
    public class FindThirdWordTest
    {
        [TestMethod]
        public void OneSpaceCheck()
        {
            StringManipulation str = new StringManipulation();
            str.MainString = "Just one space hhhh";

            Assert.AreEqual("space", str.FindThirdWord());
        }


        [TestMethod]
        public void MultiSpaceCheck()
        {
            StringManipulation str = new StringManipulation();
            str.MainString = "    Just     one     space     more     ";

            Assert.AreEqual("space", str.FindThirdWord());
        }
    }
}
