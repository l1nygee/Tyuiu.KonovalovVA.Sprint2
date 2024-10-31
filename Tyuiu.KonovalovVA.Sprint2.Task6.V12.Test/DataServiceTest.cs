using Tyuiu.KonovalovVA.Sprint2.Task6.V12.Lib;
namespace Tyuiu.KonovalovVA.Sprint2.Task6.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void FindDateOfPreviousDayValid()
        {
            DataService ds = new DataService();
            int n = 1, m = 1, g = 2024;
            string res = ds.FindDateOfPreviousDay(g,m,n);
            string wait = "2023.12.31";
            Assert.AreEqual(wait, res);
        }
    }
}