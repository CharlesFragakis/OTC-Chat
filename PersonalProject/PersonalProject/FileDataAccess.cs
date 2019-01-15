using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PersonalProject
{
    public class FileDataAccess
    {
        private string _path;

        public FileDataAccess(string path)
        {
            if (string.IsNullOrWhiteSpace(path))
            {
                throw new ArgumentNullException();
            }
            _path = path;
        }
        public void NewFileOrAppendExisting(string message)
        {
            
            if (!File.Exists(_path))
            {
                File.Create(_path);
                TextWriter tw = new StreamWriter(_path);
                tw.WriteLine("The very first line!");
                tw.Close();
            }
            else if (File.Exists(_path))
            {
                using (var tw = new StreamWriter(_path, true))
                {
                    tw.WriteLine("The next line!");
                }
            }
        }

    }
}
