using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TekCont;

namespace Test1
{
    [TestClass]
    public class Negative
    {
        [TestMethod]
        public void TestMethod1()
        {
            var page = new MainWindow();
            Assert.IsFalse(page.Proverka("11", "10", "10", "10"));
            Assert.IsFalse(page.Proverka("10", "dfsd", "20", "9"));
            Assert.IsFalse(page.Proverka("", "", "1", "1"));
            Assert.IsFalse(page.Proverka("10", "800", "30", "10"));
        }
    }
}
