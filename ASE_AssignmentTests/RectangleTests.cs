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
    public class RectangleTests
    {
        [TestMethod()]
        public void setParameterTest()
        {
            var r = new Rectangle();
            int x = 200, y = 200, width = 100, height = 100;
            r.set(x, y, height, width);
            Assert.AreEqual(200, r.x);
            Assert.AreEqual(200, r.y);
            Assert.AreEqual(100, r.width);
        }
    }
}

