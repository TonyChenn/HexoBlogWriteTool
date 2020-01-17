using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BlogWriteTools
{
    public class Config
    {
        //主配置路径
        private static string rootPath="";
        private static string themeName = "";

        public static string RootPath
        {
            get
            {
                rootPath.TrimEnd('\\');
                return rootPath + "\\";
            }
        }
        public static string themeFolder
        {
            get { return RootPath + "themes\\" + themeName; }
        }
        public static string PostFolder
        {
            get { return RootPath + "source\\_posts\\"; }
        }


        public static void Init(string path="config.dat")
        {
            string[] lines = File.ReadAllLines(path);
            rootPath = lines[0];
            themeName = lines[1];
        }
    }
}
