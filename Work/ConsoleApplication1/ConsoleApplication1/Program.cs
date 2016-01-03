using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {

        delegate string MyDelegate(string x);
        static void Main(string[] args)
        {

            MyDelegate thisDel = (string x) => x = x + "extra";
            string result = thisDel("something");
            Console.WriteLine(result);
            Console.ReadLine();
        }

        static void setString(string x)
        {
            x = "something";
            Console.WriteLine(x);

            
        }
        class Animal
        {

        }
        class dog : Animal
        {

        }
    }
}
