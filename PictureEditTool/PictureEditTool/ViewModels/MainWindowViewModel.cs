using PictureEditTool.Models;
using PictureEditTool.Utility;
using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace PictureEditTool.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private ICommand fChooseCommand;
        private ICommand convertCommand;

        private string inputFilePath;
        public string InputFilePath
        {
            get { return inputFilePath;}
            set { SetProperty(ref inputFilePath, value);}
        }

        private string outputFilePath;
        public string OutputFilePath
        {
            get { return outputFilePath; }
            set { SetProperty(ref outputFilePath, value); }
        }

        /// <summary>
        /// ファイル選択コマンド
        /// </summary>
        public ICommand ChooseFileCommand
        {
            get { return fChooseCommand = fChooseCommand ?? new DelegateCommand(ChooseFileExecute); }
        }

        /// <summary>
        /// 画像変換コマンド
        /// </summary>
        public ICommand ConvertPicCommand
        {
            get { return convertCommand = convertCommand ?? new DelegateCommand(ConvertPicExecute); }
        }

        private void ChooseFileExecute()
        {
            var path = FileChooser.FileChoose();
            if (path != "")
            {
                InputFilePath = path;
            }
            if (InputFilePath != "")
            {
                OutputFilePath = ToolUtil.GetFilePathWithoutExtension(InputFilePath, ".svg");
            }
        }

        private void ConvertPicExecute()
        {
            var caption = string.Format("PictureEditor"); // MainWindowのタイトルが欲しい
            var message = "";
            if (InputFilePath != "")
            {
                PicConverter.PicConvert(InputFilePath, OutputFilePath);
                message = string.Format("変換しました.");
            }
            else
            {
                message = string.Format("変換する画像を選択してください.");
            }
            MessageBox.Show(message, caption, MessageBoxButton.OK);
        }
    }
}
