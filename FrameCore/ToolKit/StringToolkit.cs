using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseFrame.Core
{
    public partial class CommonToolkit
    {
        public static List<string> PathParse(string str)
        {
            List<string> pathList = new List<string>();
            string p = "/BaseFrame";
            string[] pathArr = str.Split('/');
            foreach (var path in pathArr)
            {
                if (!path.Equals("") && !path.Equals("BaseFrame"))
                {
                    p = p + "/" + path;
                    pathList.Add(p);
                }
            }
            return pathList;
        }

        public static string GetLastString(string str)
        {
            string[] pathArr = str.Split('/');
            return pathArr[pathArr.Length - 1];
        }
    }
}
