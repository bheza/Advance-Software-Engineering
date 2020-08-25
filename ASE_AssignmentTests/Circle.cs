using Microsoft.VisualStudio.TestTools.UnitTesting;
using ASE_Assignment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASE_Assignment.Tests
{
    [TestClass()]
    public class CircleTests
    {
        [TestMethod()]
        public void setmethodtest()
        {
            var circle = new Circle();
            int x = 200, y = 200, radius = 100;
            circle.set(x, y, radius);
            Assert.AreEqual(200, circle.x);
        }
    }
}