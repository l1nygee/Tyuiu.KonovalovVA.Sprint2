using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.KonovalovVA.Sprint2.Task6.V12.Lib
{
    public class DataService : ISprint2Task6V12
    {
        public string FindDateOfPreviousDay(int g, int m, int n)
        {
            int daysc = 0;
            switch (m - 1)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    daysc = 31;
                    break;
                case 4:
                case 6:
                case 2:
                case 9:
                case 11:
                    daysc = 30;
                    break;
            }
            if (n == 1)
            {
                if (m == 1) return  "31" +"." + "12" + "." + (g - 1);
                else if (m<10) return daysc + "." + '0'+(m - 1) + "." + g;
                else return daysc + "." + (m - 1) + "." + g;
            }
            if (n <= 10)
            {
                if (m < 10) return "0" + (n - 1) + "." + '0' + m + "." + g;
                return "0" + (n - 1) + "." + m + "." + g;
            }
            return (n - 1) + "." + m + "." + g;
        }
    }
}
