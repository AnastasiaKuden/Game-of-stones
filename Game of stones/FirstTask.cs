﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Game_of_stones
{
    public class FirstTask
    {
        int s;
        int s1;
        int s2;

        public FirstTask()
        {            
        }

        public void FindS(double k, int n, int m, double l)
        {
            if (k % l == 0)
            {
                s = (int)(k / l) - 1;
            }
            else
            {
                s = (int)Math.Ceiling(k / l) - 1;
            }
            s1 = s - n;
            s2 = s - m;
            Console.WriteLine($"1. S1 = {s1}, стратегия: в свой первый ход Петя добавляет камушки в количестве = {n}, во второй ход увеличивает количество в {l} раза");
            Console.WriteLine($"2. S2 = {s2}, стратегия: в свой первый ход Петя добавляет камушки в количестве = {m}, во второй ход увеличивает количество в {l} раза");
        }
    }
}