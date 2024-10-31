using Tyuiu.KonovalovVA.Sprint2.Task6.V12.Lib;
namespace Tyuiu.KonovalovVA.Sprint2.Task6.V12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int g,m,n;
            Console.WriteLine("Введите g,m,n");
            g = Convert.ToInt32(Console.ReadLine());
            m = Convert.ToInt32(Console.ReadLine());
            n = Convert.ToInt32(Console.ReadLine());
            Console.Title = "Спринт #2 | Выполнил: Коновалов В.А. | ПКТб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Операции сравнения                                                *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #12                                                              *");
            Console.WriteLine("* Выполнил: Коновалов Владимир Артёмович | ПКТб-24-1                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("g = " + g);
            Console.WriteLine("m = " + m);
            Console.WriteLine("n = " + n);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine(ds.FindDateOfPreviousDay(g,m,n));
        }
    }
}
