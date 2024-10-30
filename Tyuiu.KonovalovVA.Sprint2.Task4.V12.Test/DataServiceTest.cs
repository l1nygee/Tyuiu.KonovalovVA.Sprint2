using Tyuiu.KonovalovVA.Sprint2.Task4.V12.Lib;
namespace Tyuiu.KonovalovVA.Sprint2.Task4.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CalculateValid()
        {
            double x = 1;
            double y = 1;
            DataService ds = new DataService();
            double wait  = ds.Calculate(x, y);
            Assert.AreEqual(1.034,wait);
        }
    }
}