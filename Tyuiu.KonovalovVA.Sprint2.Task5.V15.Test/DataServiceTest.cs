using Tyuiu.KonovalovVA.Sprint2.Task5.V15.Lib;
namespace Tyuiu.KonovalovVA.Sprint2.Task5.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void FindDayNameValid()
        {
            int x = 8;
            DataService ds = new DataService();
            string wait = ds.FindDayName(x);
            Assert.AreEqual("Понедельник", wait);
        }
    }
}