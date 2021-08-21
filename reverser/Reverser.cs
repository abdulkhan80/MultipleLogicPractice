using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reverser
{

    public class Reverser
    {

        public void reverser()
        {
            string getfiletype = ConfigurationManager.AppSettings["limerickFile"];
            refreshReverserFile();

            foreach (var readfilecontent in File.ReadLines(getfiletype).Reverse())
            {
                writeReverserOutput(readfilecontent);
                Console.WriteLine(readfilecontent);
            }
        }

        private void writeReverserOutput(string content)
        {

            string outputreverserfile = ConfigurationManager.AppSettings["reverserFile"];
            TextWriter tw = new StreamWriter(outputreverserfile, true);
            tw.WriteLine(content, string.Empty);
            tw.Close();
        }

        private void refreshReverserFile()
        {
            string outputreverserfile = ConfigurationManager.AppSettings["reverserFile"];
            File.WriteAllText(outputreverserfile, String.Empty);
        }
    }
}
