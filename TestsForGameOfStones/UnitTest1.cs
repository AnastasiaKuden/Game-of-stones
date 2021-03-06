using NUnit.Framework;
using Game_of_stones;
using System.Collections.Generic;
using System.Linq;

namespace TestsForGameOfStones
{
    public class Tests
    {
        FirstTask actual = new FirstTask();       

        [TestCase(24, new int[] {1, 2, 2}, new string[] {"+", "+", "*"}, ExpectedResult = 11)]
        [TestCase(44, new int[] {1, 2, 2}, new string[] {"+", "+", "*"}, ExpectedResult = 21)]
        [TestCase(42, new int[] {1, 5, 3}, new string[] {"+", "+", "*"}, ExpectedResult = 13)]        
        public int FindBadNumberTest(int k, int[] a, string[] b)
        {            
            return actual.FindBadNumber(k, a, b);            
        }


        [TestCase(24, new int[] { 1, 2, 2 }, new string[] { "+", "+", "*" }, ExpectedResult = new int[] { 9, 10})]
        [TestCase(44, new int[] { 1, 2, 2 }, new string[] { "+", "+", "*" }, ExpectedResult = new int[] { 19, 20})]
        [TestCase(42, new int[] { 1, 5, 3 }, new string[] { "+", "+", "*" }, ExpectedResult = new int[] { 8, 12})]
        public int[] CreateGraphTest(int k, int[] a, string[] b)
        {
            List<int> stone = new List<int>();
            for (int i = 1; i < k - 1; i++)
            {
                stone.Add(i);
            }
            ListOfTurns.listOfSForWin = new List<int>();
            ListOfTurns.listOfVasyaFirst = new List<int>();
            Node node = new Node();
            node.CreateBranchesOfTurns(stone, k, a, b);                       
            node.CreateListsOfStoneNumber(FindBadNumberTest(k, a, b));
            return ListOfTurns.listOfSForWin.ToArray();
        }
    }
}