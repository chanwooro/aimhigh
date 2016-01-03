using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            int A = 123;
            int B = 67890;
            string AInt = A.ToString();
            string BInt = B.ToString();
            string result = "";
            char[] AcharArray = AInt.ToCharArray();
            char[] BcharArray = BInt.ToCharArray();
            int totalLength = AcharArray.Length + BcharArray.Length;
            int switcher = 0;
            int AIndex = 0;
            int BIndex = 0;
            Console.WriteLine(AcharArray);
            Console.WriteLine(BcharArray);
            for (int i = 0; i < totalLength ; i++)
            {
                if (switcher == 0)
                {
                    if (AIndex <= AcharArray.Length)
                    {
                        result = result + AcharArray[BIndex];
                        AIndex++;
                    }
                    if (BcharArray.Length  != BIndex)
                    {
                        switcher = 1;
                    }
                   
                }
                else if (switcher == 1)
                {
                    
                    
                    if (BIndex <= BcharArray.Length)
                    {
                        result = result + BcharArray[BIndex];
                        BIndex++;
                    }
                    if (AcharArray.Length  != AIndex)
                    {
                        switcher = 0;
                    }
                  

                }

            }
            Console.WriteLine(result);
            Console.ReadLine();

        }

        public int solution(int A, int B)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            
            return 4;
        }
    }
}
