using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PictureEditTool.Utility
{
    public class ToolUtil
    {
        public static string GetFilePathWithoutExtension(string filePath, string extension)
        {
            var FileNameWithoutExtension = Path.GetFileNameWithoutExtension(filePath);
            var dir = Path.GetDirectoryName(filePath);
            var outFileName = string.Format("{0}{1}", FileNameWithoutExtension, extension);
            return string.Format("{0}\\{1}",dir, outFileName);
        }
    }
}
