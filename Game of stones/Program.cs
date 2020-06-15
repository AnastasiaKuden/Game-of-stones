using System;
using System.Collections.Generic;

namespace Game_of_stones
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = 0;
            int secondNumber = 0;
            int thirdNumber = 0;
            string firstO = "+";
            string secondO = "+";
            string thirdO = "+";
            //List<int> a = new List<int>();
            //List<string> b = new List<string>();

            Console.WriteLine("Задача: Два игрока, Петя и Ваня, играют в следующую игру. Перед игроками лежит куча камней. Игроки ходят по очереди, первый ход делает Петя. За один ход игрок может добавить в кучу разное количество камней или увеличить кучу в некое количество раз (3 варианта): <firstNumber>, <secondNumber>, <thirdNumber>. У каждого игрока есть необходимое количество камней, чтобы делать ходы. Игра завершается, когда количество камней в куче становится не менее <k>. Победителем считается игрок, сделавший последний ход, то есть первым получивший кучу, в которой будет <k> или больше камней. В начальный момент в куче было S камней (от одного, включительно, и меньше <k>).");
            Console.WriteLine("");
            Console.WriteLine("Введи свои условия и программа покажет: ");
            Console.WriteLine("1. Значения S (начальное число камней в куче), при которых у Пети есть выигрышная стратегия, причем Петя должен выиграть только за второй ход (независимо от того, как будет ходить Ваня), и выигрышную стратегию для этого значения S.");
            //Console.WriteLine("2. Значение S, при котором у Вани есть выиграшная стратегия, позволяющая ему выиграть первым или вторым ходом при любой игре Пети, и саму стратегию.");
            //Console.WriteLine("3. Значение S, при котором, у Вани нет стратегии, которая позволит ему гарантированно выиграть первым ходом.");
            Console.WriteLine("");
            Console.WriteLine("Условия:");
            Console.Write("Количество камней для победы (<k>) = ");
            int sum = Convert.ToInt32(Console.ReadLine());

            String pattern = @"([+*])+(\d+)";

            Console.Write("1 вариант увеличения кучи (<firstNumber>): ");
            string firstvar = Console.ReadLine();
            foreach (var expression in firstvar)
            {
                foreach (System.Text.RegularExpressions.Match r in
                System.Text.RegularExpressions.Regex.Matches(firstvar, pattern))
                {
                    firstNumber = Int32.Parse(r.Groups[2].Value);
                    //a.Add(n);
                    firstO = r.Groups[1].Value;
                    //b.Add(nO);
                }
            }

            Console.Write("2 вариант увеличения кучи (<secondNumber>): ");
            string secondvar = Console.ReadLine();
            foreach (var expression in firstvar)
            {
                foreach (System.Text.RegularExpressions.Match r in
                System.Text.RegularExpressions.Regex.Matches(secondvar, pattern))
                {
                    secondNumber = Int32.Parse(r.Groups[2].Value);
                    //a.Add(m);
                    secondO = r.Groups[1].Value;
                    //b.Add(mO);
                }
            }

            Console.Write("3 вариант увеличения кучи (<thirdNumber>): ");
            string thirdvar = Console.ReadLine();
            foreach (var expression in thirdvar)
            {
                foreach (System.Text.RegularExpressions.Match r in
                System.Text.RegularExpressions.Regex.Matches(thirdvar, pattern))
                {
                    thirdNumber = Int32.Parse(r.Groups[2].Value);
                    //a.Add(l);
                    thirdO = r.Groups[1].Value;
                    //b.Add(lO);
                }
            }

            int[] a = new int[3] { firstNumber, secondNumber, thirdNumber };
            string[] b = new string[3] { firstO, secondO, thirdO };
           
            Console.WriteLine("");
            Console.WriteLine("Решение: ");
            FirstTask f = new FirstTask();
            f.CreateGraph(sum, a, b);
            //f.FindS(k, a, b);
            //f.ShowStrategy(n, m, l);
            UnnecessaryS.listOfS = new List<int>();
            UnnecessaryS.listOfS2 = new List<int>();
            //SecondTask s = new SecondTask();
            //s.CreateGraph(sum, a, b);
            f.ShowResult(sum, a, b);
        }
    }
}
