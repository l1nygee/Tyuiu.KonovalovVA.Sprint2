using Tyuiu.KonovalovVA.Sprint2.Task7.V4.Lib;
namespace Tyuiu.KonovalovVA.Sprint2.Task7.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckDotInShadedAreaValid()
        {
            double x = 0.6;
            double y = 0.6;
            DataService ds  = new DataService();
            bool wait = true;
            bool ans = ds.CheckDotInShadedArea(x, y);
            Assert.AreEqual(wait, ans);

        }
    }
}