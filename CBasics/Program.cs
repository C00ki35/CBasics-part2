
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace CBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            //File methods - check user security settings before each operations, slower if doing lots of operations
            var path = "Somefilename path";
            File.Copy(path, path, true);
            File.Delete(path);
            if (File.Exists(path))
            {
                //Do something
            }
            var content = File.ReadAllText(path);


            //File Instance methods - only checks security settings of user once
            var fileInfo = new FileInfo(path);
            fileInfo.CopyTo(path);
            fileInfo.Delete();
            if (fileInfo.Exists)
            {
                //Do something
            }



        }
    }
}


