using NUnit.Framework;
using Game_of_stones;

namespace TestsForGameOfStones
{
    public class Tests
    {
        FirstTask actual = new FirstTask();

        [TestCase(40, 1, 2, 2, ExpectedResult = new int[] {18, 17})]
        [TestCase(24, 1, 2, 2, ExpectedResult = new int[] {10, 9})]
        [TestCase(42, 1, 5, 3, ExpectedResult = new int[] {12, 8})]
        [TestCase(0, 0, 0, 0, ExpectedResult = new int[] {})]
        [TestCase(0, 1, 0, 1, ExpectedResult = new int[] {})]
        [TestCase(80, 3, 6, 7, ExpectedResult = new int[] {8, 5})]
        public int[] TestFindS(double k, int n, int m, double l)
        {            
            actual.FindS(k, n, m, l);
            return actual.DoArrayWithS();
        }
    }
}