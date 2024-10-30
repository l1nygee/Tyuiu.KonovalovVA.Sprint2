using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.KonovalovVA.Sprint2.Task2.V12.Lib
{
    public class DataService : ISprint2Task2V12
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            if ((x >= 3 && y >= 3) && (x <= 5 && y <= 7) || (x >= 6 && y >= 5) && (x <= 12 && y <= 8) || (x >= 9 && y >= 3) && (x <= 12 && y <= 4) ||
                 (x >= 11 && y >= 3) && (x <= 12 && y <= 12) || (x == 13 && y >=6 && y <= 8) || (x >= 6 && y >= 5) && (x <= 7 && y <= 11) || 
                  (y == 11 && x >= 3 && x<= 7) || (x==7 && y == 12))
            {
                return true;
            }
            else { return false; };

        }
    }
}
