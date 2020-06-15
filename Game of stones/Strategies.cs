using System;
using System.Collections.Generic;
using System.Text;

namespace Game_of_stones
{
    public class Strategies
    {
        
        public Strategies()
        {            
        }

        public void FindPetyaFirstTurn (int badNumber, int[] a, string[] b)
        {
            foreach (int v in ListOfTurns.listOfSForWin)
            {
                if (b[0] == "+" && v + a[0] == badNumber)
                {
                    string turn1 = $"   Если камушков {v}, то он прибавляет {a[0]} и получается {badNumber} штук";  
                    if (turn1 != null)
                    {
                        Console.WriteLine(turn1);
                    }
                }
                else if (b[0] == "*" && v * a[0] == badNumber)
                {
                    string turn1 = $"   Если камушков {v}, то он увеличивает в {a[0]} раз(а) и получается {badNumber} штук";
                    if (turn1 != null)
                    {
                        Console.WriteLine(turn1);
                    }
                }

                if (b[1] == "+" && v + a[1] == badNumber)
                {
                    string turn2 = $"   Если камушков {v}, то он прибавляет {a[1]} и получается {badNumber} штук";
                    if (turn2 != null)
                    {
                        Console.WriteLine(turn2);
                    }
                }
                else if(b[1] == "*" && v * a[1] == badNumber)
                {
                    string turn2 = $"   Если кушков {v}, то он увеличивает в {a[1]} раз(а) и получается {badNumber} штук";
                    if (turn2 != null)
                    {
                        Console.WriteLine(turn2);
                    }
                } 

                if (b[2] == "+" && v + a[2] == badNumber)
                {
                    string turn3 = $"   Если камушков {v}, то он прибавляет {a[2]} и получается {badNumber} штук";
                    if (turn3 != null)
                    {
                        Console.WriteLine(turn3);
                    }
                }
                else if (b[2] == "*" && v * a[2] == badNumber)
                {
                    string turn3 = $"   Если камушков {v}, то он увеличивает в {a[2]} раз(а) и получается {badNumber} штук";
                    if (turn3 != null)
                    {
                        Console.WriteLine(turn3);
                    }
                }
            }
        }
    }
}
