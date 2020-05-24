using System;
using System.Collections.Generic;
using System.Text;

namespace Game_of_stones
{
    public class Node
    {
        List<Node> nextNumber;
        List<int> values;
        int var1, var2, var3;
        
        public Node()
        {
            nextNumber = new List<Node>();
            values = new List<int>();            
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

        public void CreateBranchesOfTurns(List<int> stones, int k, int[] a, string[] b)
        {
            foreach(int numberOfStones in stones)
            {
                
                Node nN = CreateNewNode(numberOfStones);

                if (numberOfStones >= k)
                {

                    continue;
                }                

                if (b[0] == "+")
                {
                    var1 = numberOfStones + a[0];
                }
                else
                {
                    var1 = numberOfStones * a[0];
                }
                if (b[1] == "+")
                {
                    var2 = numberOfStones + a[1];
                }
                else
                {
                    var2 = numberOfStones * a[1];
                }
                if (b[2] == "+")
                {
                    var3 = numberOfStones + a[2];
                }
                else
                {
                    var3 = numberOfStones * a[2];
                }                

                List<int> newNumberOfStones = CreateNewListOfStones(var1, var2, var3);                
                nN.CreateBranchesOfTurns(newNumberOfStones, k, a, b);                              
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
                    UnnecessaryS.listOfS.Add(values[0]);                                      
                }
                //else if (values.Count == 3)
                //{
                //    UnnecessaryS.listOfS2.Add(values[1]);
                //}
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
                //if (values.Count == 4 && !UnnecessaryS.listOfS.Contains(values[0]) && !UnnecessaryS.listOfS2.Contains(values[1]))
                //{
                //    foreach (int s in values)
                //    {
                //        Console.Write(s + " ");
                //    }
                //    Console.WriteLine();
                //}
                if (values.Count == 3 && !UnnecessaryS.listOfS.Contains(values[0]))
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
