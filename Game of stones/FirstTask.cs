using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace Game_of_stones
{
    public class FirstTask
    {
        int s;
        int s1;
        int s2;
        int[] a;
        
        public FirstTask()
        {            
        }

        //public void FindS(double k, int[] a, string[] b)
        //{
        //    maxValue = a.Max();
        //    indexOfMaxValue = Array.IndexOf(a, maxValue);
        //    firstOperator = b[indexOfMaxValue];
        //    if (firstOperator == "*")
        //    {
        //        if(k % maxValue == 0)
        //        {
        //            s = (int)(k / maxValue) - 1;
        //        }
        //        else
        //        {
        //            s = (int)Math.Ceiling(k / maxValue) - 1;
        //        }
        //        s1 = s - n;
        //        s2 = s - m;
        //    }
        //    else
        //    {

        //        s = (int)(k - maxValue) - 1;
        //    }
        //}

        
        public void ShowStrategy(int n, int m, double l)
        {
            if (s != 0)
            {
                Console.WriteLine($"1) S1 = {s1}, стратегия: в свой первый ход Петя добавляет камушки в количестве = {n}, во второй ход увеличивает количество в {l} раз(а)");
                Console.WriteLine($"   S2 = {s2}, стратегия: в свой первый ход Петя добавляет камушки в количестве = {m}, во второй ход увеличивает количество в {l} раз(а)");
            }
            else
            {
                Console.WriteLine("Введены неправильные значения!");
            }
        }

        public int[] DoArrayWithS()
        {
            if (s != 0)
            {
                a = new int[2] { s1, s2 };
                return a;
            }
            else
            {
                a = new int[0];
                return a;
            }
        }
    }
}
