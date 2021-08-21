using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemWrapper;
using SystemWrapper.IO;

namespace FileSystemWrapWorkout
{
    public class FileService : IFileService
    {
        private readonly IFileWrap _fs;

        public FileService()
        {
            _fs = new FileWrap();
        }
        public void FileWrapService(string output)
        {
            string path = @"C:\Users\Adeel Khan\Documents\Visual Studio 2015\Projects\FizzBuzzAbdulK\FileSystemWrapWorkout\Logs\sdf.txt";

            if (this._fs.Exists(path))
            {
                this._fs.WriteAllText(path, output);
            }
            else
            {
                this._fs.Create(path);
                this._fs.Open(path, System.IO.FileMode.Append);
                this._fs.WriteAllText(path, output);
            }
        }
    }

    public interface IFileService
    {
        void FileWrapService(string output);
    }
}
