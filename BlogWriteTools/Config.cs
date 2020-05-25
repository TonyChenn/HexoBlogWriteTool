using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

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
                return rootPath.TrimEnd('\\');
            }
        }
        public static string themeFolder
        {
            get { return RootPath + "\\themes\\" + themeName; }
        }
        public static string PostFolder
        {
            get { return RootPath + "\\source\\_posts\\"; }
        }


        public static void Init(string path="config.dat")
        {
            if(!File.Exists(path))
            {
                File.Create(path).Dispose();
                MessageBox.Show("请配置Hexo信息");
            }
            string[] lines = File.ReadAllLines(path);
            if(lines.Length>=2)
            {
                rootPath = lines[0];
                themeName = lines[1];
            }
        }
    }
}
