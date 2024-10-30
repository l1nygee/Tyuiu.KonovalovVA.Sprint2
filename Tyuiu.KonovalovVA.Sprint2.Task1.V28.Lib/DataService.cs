﻿using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.KonovalovVA.Sprint2.Task1.V28.Lib
{
    public class DataService : ISprint2Task1V28
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = new bool[6];
            res[0] = c == d | a != b;
            res[1] = a == b & c != d;
            res[2] = a != b || c == d;
            res[3] = a == b && c != d;
            res[4] = !(a==b);
            res[5] = a < b ^ c == d;
            return res;
        }
    }
}