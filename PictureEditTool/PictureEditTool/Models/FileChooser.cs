using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PictureEditTool.Models
{
    public class FileChooser
    {
        /// <summary>
        /// ファイル選択ダイアログを表示し,選択したファイルのダイアログを返します.
        /// </summary>
        /// <returns>選択したファイルのパス</returns>
        public static string FileChoose()
        {
            // return string.Format("工事中！");

            var ofd = new OpenFileDialog();

            ofd.FileName = "";

            ofd.Filter = "PNGファイル(*.png)|*.png|すべてのファイル(*.*)|*.*";
            ofd.FilterIndex = 0;

            //タイトルを設定する
            ofd.Title = "開くファイルを選択してください";
            //ダイアログボックスを閉じる前に現在のディレクトリを復元するようにする
            ofd.RestoreDirectory = true;

            //ダイアログを表示する
            ofd.ShowDialog();

            return ofd.FileName;
        }
    }
}
