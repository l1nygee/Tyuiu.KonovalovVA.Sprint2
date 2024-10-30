using Tyuiu.KonovalovVA.Sprint2.Task2.V12.Lib;
namespace Tyuiu.KonovalovVA.Sprint2.Task2.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 6; int y = 4;
            bool wait = false;
            bool res = ds.CheckDotInShadedArea(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}