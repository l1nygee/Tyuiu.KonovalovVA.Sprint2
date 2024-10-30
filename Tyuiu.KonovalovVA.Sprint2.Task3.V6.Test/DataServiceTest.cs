using Tyuiu.KonovalovVA.Sprint2.Task3.V6.Lib;

namespace Tyuiu.KonovalovVA.Sprint2.Task3.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CalculateValid()
        {
            double x = 3;
            DataService ds = new DataService();
            double y = ds.Calculate(x);
            Assert.AreEqual(4, y);
            
        }
    }
}