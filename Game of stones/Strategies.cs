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

        public void ShowPetyaFirstTurn (int badNumber, int[] a, string[] b)
        {
            foreach (int v in ListOfTurns.listOfSForWin)
            {
                if (b[0] == "+" && v + a[0] == badNumber)
                {
                    Console.WriteLine($"    Если камушков {v}, то он прибавляет {a[0]} и получается {badNumber} штук(и)");                   
                }
                else if (b[0] == "*" && v * a[0] == badNumber)
                {
                    Console.WriteLine($"    Если камушков {v}, то он увеличивает в {a[0]} раз(а) и получается {badNumber} штук(и)");                    
                }

                if (b[1] == "+" && v + a[1] == badNumber)
                {
                    Console.WriteLine($"    Если камушков {v}, то он прибавляет {a[1]} и получается {badNumber} штук(и)");                    
                }
                else if(b[1] == "*" && v * a[1] == badNumber)
                {
                    Console.WriteLine($"    Если камушков {v}, то он увеличивает в {a[1]} раз(а) и получается {badNumber} штук(и)");                    
                } 

                if (b[2] == "+" && v + a[2] == badNumber)
                {
                    Console.WriteLine($"    Если камушков {v}, то он прибавляет {a[2]} и получается {badNumber} штук(и)");                    
                }
                else if (b[2] == "*" && v * a[2] == badNumber)
                {
                    Console.WriteLine($"    Если камушков {v}, то он увеличивает в {a[2]} раз(а) и получается {badNumber} штук(и)");                    
                }
            }
        }

        public void ShowVanyaFirstTurn(int badNumber, int[] a, string[] b)
        {
            if (b[0] == "+")
            {
                Console.WriteLine($"    Вася может добавить {a[0]} и получается {badNumber + a[0]} штук(и)");                
            }
            else 
            {
                Console.WriteLine($"    Вася может увеличить в {a[0]} раз(а) и получается {badNumber * a[0]} штук(и)");                
            }

            if (b[1] == "+")
            {
                Console.WriteLine($"    Вася может добавить {a[1]} и получается {badNumber + a[1]} штук(и)");
               
            }
            else
            {
                Console.WriteLine($"    Вася может увеличить в {a[1]} раз(а) и получается {badNumber * a[1]} штук(и)");
                
            }

            if (b[2] == "+")
            {
                Console.WriteLine($"    Вася может добавить {a[2]} и получается {badNumber + a[2]} штук(и)");                
            }
            else
            {
                Console.WriteLine($"    Вася может увеличить в {a[2]} раз(а) и получается {badNumber * a[2]} штук(и)");               
            }            
        }

        public void ShowPetyaSecondTurn(int k, int[] a, string[] b)
        {
            foreach (int v in ListOfTurns.listOfVasyaFirst)
            {
                if (b[0] == "+" && v + a[0] >= k)
                {
                    Console.WriteLine($"    Если камушков получилось {v}, то Петя прибавляет {a[0]} и получается {v + a[0]} штук(и)");                    
                }
                else if (b[0] == "*" && v * a[0] >= k)
                {
                    Console.WriteLine($"    Если камушков получилось {v}, то Петя увеличивает их в {a[0]} раз(а) и получается {v * a[0]} штук(и)");                    
                }

                if (b[1] == "+" && v + a[1] >= k)
                {
                    Console.WriteLine($"    Если камушков получилось {v}, то Петя прибавляет {a[1]} и получается {v + a[1]} штук(и)");
                }
                else if (b[1] == "*" && v * a[1] >= k)
                {
                    Console.WriteLine($"    Если камушков получилось {v}, то Петя увеличивает их в {a[1]} раз(а) и получается {v * a[1]} штук(и)");
                }

                if (b[2] == "+" && v + a[2] >= k)
                {
                    Console.WriteLine($"    Если камушков получилось {v}, то Петя прибавляет {a[2]} и получается {v + a[2]} штук(и)");
                }
                else if (b[2] == "*" && v * a[2] >= k)
                {
                    Console.WriteLine($"    Если камушков получилось {v}, то Петя увеличивает их в {a[2]} раз(а) и получается {v * a[2]} штук(и)");
                }
            }
        }
    }
}
