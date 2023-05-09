using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mobile_Management;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void testInput_Received()
        {
            bool expected = false;
            UserControl5 fr = new UserControl5();
            //expected = fr.testInput("2804", "123");
            Assert.AreEqual(true, expected);
        }
    }
}