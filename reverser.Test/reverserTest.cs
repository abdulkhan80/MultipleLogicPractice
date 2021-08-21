using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text;

namespace reverser.Test
{
    [TestClass]
    public class reverserTest
    {
        /*//incomplete due to time restricting...*/
        [TestMethod]
        public void Reverser_Test()
        {
            
            //Reverser rev = new Reverser();
            //rev.reverser();
        }

        private StringBuilder SetFileDate()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("From an ancient Egyptian papyrus,");
            sb.Append("A professor translated a virus.");
            sb.Append("It was rather terrific,");
            sb.Append("For an old hieroglyphic,");
            sb.Append("His computer was cursed by Osiris.");

            return sb;

        }
    }
}
