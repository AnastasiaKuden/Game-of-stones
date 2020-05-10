using System;
using System.Collections.Generic;
using System.Text;

namespace Game_of_stones
{
    class Node
    {
        List<Node> nextNumber;
        List<int> values;        
        List<int> S;

        public Node()
        {
            nextNumber = new List<Node>();
            values = new List<int>();
            S = new List<int>();
        }

        public List<int> CreateNewListOfStones (int var1, int var2, int var3)
        {
            List<int> newListOfStones = new List<int>();
            newListOfStones.Add(var1);
            newListOfStones.Add(var2);
            newListOfStones.Add(var3);
            return newListOfStones;            
        }

        public Node CreateNewNode(int numberOfStones)
        {
            Node newnode = new Node();
            foreach (int v in values)
            {
                newnode.values.Add(v);
            }
            newnode.values.Add(numberOfStones);
            nextNumber.Add(newnode);
            return newnode;
        }

        public void CreateBranchesOfTurns(List<int> stones, double k, int n, int m, double l)
        {
            foreach(int numberOfStones in stones)
            {                
                int var1 = numberOfStones + n;
                int var2 = numberOfStones + m;
                int var3 = numberOfStones * (int)l;                  
                List<int> newNumberOfStones = CreateNewListOfStones(var1, var2, var3);
                Node nN = CreateNewNode(numberOfStones);
                if (numberOfStones >= (int)k)
                {                   
                    continue;
                }                
                nN.CreateBranchesOfTurns(newNumberOfStones, k, n, m, l);                              
            }            
        }

        public void Show()
        {
            if (nextNumber.Count != 0)
            {
                foreach (Node n in nextNumber)
                {
                    n.Show();                            
                }
            }
            else
            {
                if (values.Count == 2)
                {
                    S.Add(values[0]);                    
                }                                      
            }            
        }

        public void ShowSAndStrategy()
        {
            if (nextNumber.Count != 0)
            {
                foreach (Node n in nextNumber)
                {
                    n.ShowSAndStrategy();
                }
            }
            else
            {
                if (values.Count == 3 && //S.Contains(values[0]) == false) 
                {
                    foreach (int s in values)
                    {
                        Console.Write(s + " ");
                    }
                    Console.WriteLine();
                }                
            }
        }
    }
}
