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

                if (numberOfStones >= k || values.Count == 4)
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
        
        public void ShowSAndStrategy(int val)
        {
            if (nextNumber.Count != 0)
            {
                foreach (Node n in nextNumber)
                {
                    n.ShowSAndStrategy(val);
                }
            }
            else
            {
                if (values.Count == 4 && values[1] == val)
                {
                    if (!ListOfTurns.listOfSForWin.Contains(values[0]))
                    {
                        ListOfTurns.listOfSForWin.Add(values[0]);
                    }

                    ListOfTurns.listOfS.Add(values[0]);
                    ListOfTurns.listOfPetyaFirst.Add(values[1]);
                    ListOfTurns.listOfVasyaFirst.Add(values[2]);
                    ListOfTurns.listOfPetyaSecond.Add(values[3]);
                                        
                    //foreach (int s in values)
                    //{
                        
                    //    Console.Write(s + " ");
                    //}
                    //Console.WriteLine();
                }                
            }
        }
    }
}
