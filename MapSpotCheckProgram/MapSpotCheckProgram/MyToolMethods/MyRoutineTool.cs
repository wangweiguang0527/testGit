using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MapSpotCheckProgram
{
    /// <summary>
    /// 常规工具
    /// </summary>
    class MyRoutineTool
    {
        /// <summary>  
        /// 取向上几层的目录  
        /// </summary>  
        /// <param name="sourcePath">文件目录</param>  
        /// <param name="deep">向上几层</param>  
        /// <returns>处理后的目录</returns>  
        public static string GetPathByParentDeep(string sourcePath, int deep)
        {
            if (string.IsNullOrEmpty(sourcePath) || deep < 0)
            {
                return sourcePath;
            }

            string tempPath = sourcePath.Replace(@"/", @"\");

            if (tempPath.EndsWith(@"\"))
            {
                deep += 1;
            }

            for (int i = 0; i < deep; i++)
            {
                if (!tempPath.Contains(@"\"))
                {
                    break;
                }

                tempPath = tempPath.Substring(0, tempPath.LastIndexOf(@"\"));
            }
            return tempPath;
        }  
    }
}
