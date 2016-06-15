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
        private int x;
        private int y;

        [TestMethod()]
        public void CarsTravelingTest()
        {

            Assert.Fail();
        }

        [TestMethod()]
        public void PairofCarsTest()
        {
            int e = 0;
            int w = 1;

            //  Program PairoFCars = new PairofCars
            // Assert.AreEqual(Program.PairofCars(x, y), e);
            Assert.Fail();
        }

        [TestMethod()]
        public void TravelingEastTest()
        {
            int east = 0;

            Assert.AreEqual(Program.TravelingEast(), east);

        }
    }
}