using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[,] a = { { 1, 2, 3, 4 },
                    { 5, 6, 7, 8 },
                    { 1, 2, 3, 4 },
                    { 5, 6, 7, 8 } };
            int p1 = 1;
            int t1 = 1;
            int p2 = 2;
            int t2 = 0;
            int d = 4 * (-5);
            int result = ConsoleApp1.Program.product(a, p1, t1, p2, t2);
            Assert.AreEqual(d, result);
        }
    }
}
