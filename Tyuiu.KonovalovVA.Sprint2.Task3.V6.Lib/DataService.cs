using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.KonovalovVA.Sprint2.Task3.V6.Lib
{
    public class DataService : ISprint2Task3V6
    {
        public double Calculate(double x)
        {
            double y = 0;
            if (x == 0)
            {
                y = 0.75;
            }
            else if (x > 0)
            {
                y = x + Math.Pow(((x - 15) / (x - 10)), x - 3);
            }
            else if (x > -10)
            {
                y = Math.Pow((x*x*x*x+1/(x*x)),x);
            }else if (x < -10)
            {
                y = x+10*x - (1 / x);
            }
            return Math.Round(y,3);
        }
    }
}
