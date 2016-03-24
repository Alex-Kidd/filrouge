using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testSplit
{
    class Program
    {
        static void Main(string[] args)
        {
            string mail = "sauvage.alexis66@gmail.com";
            char separateur = '@';
            char separateur2 = '.';
            string[] substrings = mail.Split(separateur);
            string[] subsubstrings;
            subsubstrings = substrings[0].Split(separateur2);
            Console.WriteLine(subsubstrings [0]) ;
            Console.WriteLine(subsubstrings[1]);
            Console.WriteLine(substrings[1]);



                Console.ReadKey();
        }
    }
}
