using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FileSystemWrapWorkout;
using Moq;

namespace reverser.Test
{
    [TestClass]
    public class FileSystemServiceTest
    {
        [TestMethod]
        public void WritingTotheFile_Test()
        {
            string text = "something something";
            FileService fs = new FileService();

            fs.FileWrapService(text);
        }

        [TestMethod]
        public void WritingTotheFile_CheckifFileExits_Test()
        {
            string text = "something something";
            FileService fs = new FileService();

            fs.FileWrapService(text);
        }

    }
}
