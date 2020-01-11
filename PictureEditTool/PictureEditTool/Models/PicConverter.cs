using ImageMagick;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PictureEditTool.Models
{
    public class PicConverter
    {
        /// <summary>
        /// 画像変換を行う
        /// </summary>
        /// <param name="inputPic"></param>
        /// <param name="outputPic"></param>
        public static void PicConvert(string inputPic, string outputPic)
        {
            using (var img = new MagickImage(inputPic) { Format = MagickFormat.Svg })
            {
                img.Write(outputPic);
            }
        }
    }
}
