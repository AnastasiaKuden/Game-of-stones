using System;
using System.Collections.Generic;
using System.Text;

namespace Game_of_stones
{
    public class FirstTask
    {
        Node start;
        List<int> stones;       

        public FirstTask()
        {
            start = new Node();
            stones = new List<int>();            
        }

        public void CreateGraph(int k, int[] a, string[] b)
        {            
            for(int i = 1; i < k - 1; i++)
            {
                stones.Add(i);
            }
            start.CreateBranchesOfTurns(stones, k, a, b);            
        }

        public void ShowResult(int k, int[] a, string[] b)
        {
            int var1, var2, var3;
            if (b[0] == "+")
            {
                var1 = k - a[0];
            }
            else
            {
                var1 = (int)Math.Ceiling(k / (double)a[0]);
            }
            if (b[1] == "+")
            {
                var2 = k - a[1];
            }
            else
            {
                var2 = (int)Math.Ceiling(k / (double)a[1]);
            }
            if (b[2] == "+")
            {
                var3 = k - a[2];
            }
            else
            {
                var3 = (int)Math.Ceiling(k / (double)a[2]);
            }
            int var4 = Math.Min(var1, var2);
            int var = Math.Min(var4, var3);
            int val = var - 1;
            start.Show();
            start.ShowSAndStrategy(val);
        }
    }
}
