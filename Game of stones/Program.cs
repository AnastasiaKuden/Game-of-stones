using System;
using System.Collections.Generic;
using Game_of_stones.Exceptions;

namespace Game_of_stones
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isError;
            int sum = 0;
            int firstNumber = 0;
            int secondNumber = 0;
            int thirdNumber = 0;
            string firstO = "+";
            string secondO = "+";
            string thirdO = "+";            
            string firstvar = "";
            string secondvar = "";            

            Console.WriteLine("Задача: Два игрока, Петя и Ваcя, играют в следующую игру. Перед игроками лежит куча камней. Игроки ходят по очереди, первый ход делает Петя. За один ход игрок может добавить в кучу разное количество камней или увеличить кучу в некое количество раз (3 варианта). У каждого игрока есть необходимое количество камней, чтобы делать ходы. Игра завершается, когда количество камней в куче становится не менее <k>. Победителем считается игрок, сделавший последний ход, то есть первым получивший кучу, в которой будет <k> или больше камней. В начальный момент в куче было S камней.");
            Console.WriteLine("");
            Console.WriteLine("Введи свои условия и программа покажет: ");
            Console.WriteLine("Значения S (начальное число камней в куче), при которых у Пети есть выигрышная стратегия, причем Петя должен выиграть только за второй ход (независимо от того, как будет ходить Ваcя), и выигрышную стратегию для этого значения S.");            
            Console.WriteLine("");
            Console.WriteLine("Условия:");

            do
            {
                isError = false;
                try
                {
                    Console.Write("Количество камней для победы (<k>)(введи число больше единицы) = ");
                    sum = Convert.ToInt32(Console.ReadLine());
                    ClassForExceptions.CheckFinishNumber(sum);
                }
                catch(CheckFinishNumberException ex)
                {
                    Console.WriteLine(ex.Message);
                    isError = true;
                }
                catch(FormatException)
                {
                    Console.WriteLine("Значение неправильного формата, введите число.");
                    isError = true;
                }
            }
            while (isError);

            String pattern = @"([+*])+(\d+)";

            do
            {
                isError = true;
                try
                {
                    Console.Write("1 вариант увеличения кучи(введи оператор и оперант слитно, например, '+1'): ");
                    firstvar = Console.ReadLine();
                    foreach (var expression in firstvar)
                    {
                        foreach (System.Text.RegularExpressions.Match r in
                        System.Text.RegularExpressions.Regex.Matches(firstvar, pattern))
                        {
                            firstNumber = Int32.Parse(r.Groups[2].Value);
                            firstO = r.Groups[1].Value;
                        }
                    }
                    ClassForExceptions.CheckTheOperatorAndOperand(firstNumber);
                }
                catch (CheckTheOperatorAndOperandException ex)
                {
                    Console.WriteLine(ex.Message);
                    isError = false;
                }
            }
            while (isError == false);

            do
            {
                isError = false;
                try
                {
                    Console.Write("2 вариант увеличения кучи: ");
                    secondvar = Console.ReadLine();
                    foreach (var expression in secondvar)
                    {
                        foreach (System.Text.RegularExpressions.Match r in
                        System.Text.RegularExpressions.Regex.Matches(secondvar, pattern))
                        {
                            secondNumber = Int32.Parse(r.Groups[2].Value);
                            secondO = r.Groups[1].Value;
                        }
                    }
                    ClassForExceptions.CheckTheOperatorAndOperand(secondNumber);
                    ClassForExceptions.CheckVariant(firstvar, secondvar);
                }
                catch (CheckTheOperatorAndOperandException ex)
                {
                    Console.WriteLine(ex.Message);
                    isError = true;
                }
                catch(CheckVariantException ex)
                {
                    Console.WriteLine(ex.Message);
                    isError = true;
                }
            }
            while (isError);

            do
            {
                isError = true;
                try
                {
                    Console.Write("3 вариант увеличения кучи: ");
                    string thirdvar = Console.ReadLine();
                    foreach (var expression in thirdvar)
                    {
                        foreach (System.Text.RegularExpressions.Match r in
                        System.Text.RegularExpressions.Regex.Matches(thirdvar, pattern))
                        {
                            thirdNumber = Int32.Parse(r.Groups[2].Value);
                            thirdO = r.Groups[1].Value;
                        }
                    }
                    ClassForExceptions.CheckTheOperatorAndOperand(thirdNumber);
                    ClassForExceptions.CheckVariant(firstvar, secondvar, thirdvar);
                }
                catch (CheckTheOperatorAndOperandException ex)
                {
                    Console.WriteLine(ex.Message);
                    isError = false;
                }
                catch (CheckVariantException ex)
                {
                    Console.WriteLine(ex.Message);
                    isError = false;
                }
            }
            while (isError == false);

            int[] a = new int[3] { firstNumber, secondNumber, thirdNumber };
            string[] b = new string[3] { firstO, secondO, thirdO };

            Console.WriteLine("");            
            Console.WriteLine("Решение: ");
            FirstTask f = new FirstTask();            
            ListOfTurns.listOfSForWin = new List<int>();
            ListOfTurns.listOfVasyaFirst = new List<int>();            
            f.CreateGraph(sum, a, b);            
            f.ShowResult(sum, a, b);            
        }
    }
}
