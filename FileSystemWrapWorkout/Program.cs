using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSystemWrapWorkout
{
    class Program
    {
        static void Main(string[] args)
        {
            FileService fs = new FileService();

            string text = "something something";
            fs.FileWrapService(text);

            Console.ReadKey();
        }
    }
}
