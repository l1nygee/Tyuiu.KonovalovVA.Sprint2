using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.KonovalovVA.Sprint2.Task7.V4.Lib
{
    public class DataService : ISprint2Task7V4
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            if (x * x + y * y <= 1 && y >= 0 && (x * x + y * y >= 0.3 && x >= 0 && y >= 0)) return true;
            return false;
        }
    }
}
