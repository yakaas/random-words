using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yakaas.Words
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine(RandomWords.GetSomeRandomDescription());
                System.Threading.Thread.Sleep(1000);
            }

        }
    }
}
