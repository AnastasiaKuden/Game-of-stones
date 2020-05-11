using System;
using System.Collections.Generic;

namespace Game_of_stones
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = 0;
            double m = 0;
            double l = 0;
            Console.WriteLine("Задача: Два игрока, Петя и Ваня, играют в следующую игру. Перед игроками лежит куча камней. Игроки ходят по очереди, первый ход делает Петя. За один ход игрок может добавить в кучу разное количество камней или увеличить кучу в некое количество раз (3 варианта): <n>, <m>, <l>. У каждого игрока есть необходимое количество камней, чтобы делать ходы. Игра завершается, когда количество камней в куче становится не менее <k>. Победителем считается игрок, сделавший последний ход, то есть первым получивший кучу, в которой будет <k> или больше камней. В начальный момент в куче было S камней (от одного, включительно, и меньше <k>).");
            Console.WriteLine("");
            Console.WriteLine("Введи свои условия и программа покажет: ");
            Console.WriteLine("1. Значения S (начальное число камней в куче), при которых у Пети есть выигрышная стратегия, причем Петя должен выиграть только за второй ход (независимо от того, как будет ходить Ваня), и выигрышную стратегию для этого значения S.");
            Console.WriteLine("2. Значение S, при котором у Вани есть выиграшная стратегия, позволяющая ему выиграть первым или вторым ходом при любой игре Пети, и саму стратегию.");
            Console.WriteLine("3. Значение S, при котором, у Вани нет стратегии, которая позволит ему гарантированно выиграть первым ходом.");
            Console.WriteLine("");
            Console.WriteLine("Условия:");
            Console.Write("Количество камней для победы (<k>) = ");
            double k = Convert.ToDouble(Console.ReadLine());
            Console.Write("1 вариант увеличения кучи (<n>) = ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("2 вариант увеличения кучи (<m>) = ");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.Write("3 вариант увеличения кучи (<l>): ");
            double l = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("Решение: ");
            FirstTask f = new FirstTask();
            f.FindS(k, n, m, l);
            f.ShowStrategy(n, m, l);
            UnnecessaryS.listOfS = new List<int>();
            SecondTask s = new SecondTask();
            s.CreateGraph(k, n, m, l);
        }
    }
}
