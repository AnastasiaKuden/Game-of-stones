using System;
using System.Collections.Generic;
using System.Text;

namespace Game_of_stones
{
    class SecondTask
    {
        Node start;
        List<int> stones;

        public SecondTask()
        {
            start = new Node();
            stones = new List<int>();
        }

        public void CreateGraph(double k, int n, int m, double l)
        {            
            for(int i = 1; i < k; i++)
            {
                stones.Add(i);
            }
            start.CreateBranchesOfTurns(stones, k, n, m, l);
            start.Show();
            start.ShowSAndStrategy();
        }
    }
}
