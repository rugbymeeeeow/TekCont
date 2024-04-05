using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TekCont;

namespace Test_TekCont
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var page = new MainWindow();
            Assert.IsTrue(page.Proverka("10", "10", "10", "10"));
            Assert.IsTrue(page.Proverka("10", "30", "20", "9"));
            Assert.IsTrue(page.Proverka("1", "1", "1", "1"));
            Assert.IsTrue(page.Proverka("10", "50", "30", "10"));
        }
    }
}
