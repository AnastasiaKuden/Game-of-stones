using System;
using System.Collections.Generic;
using System.Text;

namespace Game_of_stones
{
    public class SecondTask
    {
        Node start;
        List<int> stones;

        public SecondTask()
        {
            start = new Node();
            stones = new List<int>();
        }

        public void CreateGraph(double k, int[] a, string[] b)
        {            
            for(int i = 1; i < k; i++)
            {
                stones.Add(i);
            }
            start.CreateBranchesOfTurns(stones, k, a, b);
            start.Show();
            start.ShowSAndStrategy();
        }
    }
}
