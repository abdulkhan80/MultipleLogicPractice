using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Configuration;

namespace reverser
{
    class Program
    {
        static void Main(string[] args)
        {

            Reverser rev = new Reverser();
            rev.reverser();

            Console.ReadKey();
        }

        
    }
}
