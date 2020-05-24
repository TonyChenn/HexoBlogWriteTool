using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogWriteTools
{
    public class FileUtil
    {
        public static void CreateFile(string path,string name)
        {
        }

        public static void WriteAllText(string filePath,string content)
        {
            File.WriteAllText(filePath, content);
        }
    }
}
