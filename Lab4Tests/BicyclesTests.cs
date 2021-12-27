using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4.Tests
{
    [TestClass()]
    public class BicyclesTests
    {
        [TestMethod()]
        public void GetInfoTest()
        {
            Bicycles bike = new Bicycles();
            int WheelRadius = 80;
            BicyclesType type = BicyclesType.mountain;

            string str2 = "Велосипед\r\nРадиус колес - 80 см\r\nТип: Горный";

            Assert.AreEqual(str2, bike.GetInfo());
        }
    }
}