using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApplication1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Tests
{
    [TestClass()]
    public class ProgramTests
    {
       

       
        [TestMethod()]
        public void TravelingEastTest()
        {
            int east = 0;

            Assert.AreEqual(Program.TravelingEast(), east);

        }

        [TestMethod()]
        public void TravelingWestTest()
        {
            int west = 1;

            Assert.AreEqual(Program.TravelingWest(), west);
        }

        [TestMethod()]
        public void PairsPassingTest()
        {
            int x = -1;
            Assert.AreEqual(Program.PairsPassingCars(),x);
           
        }
       

        [TestMethod()]
        public void IsPairTest()
        {
            Assert.IsTrue(Program.IsPair());

        }
    }
}