using KiteTools.ModelBuilder.Models;
using Microsoft.Win32;
using MiniExcelLibs;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace KiteTools.ModelBuilder
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            // 读取对应文件夹的Excel文件
            var dic = new OpenFileDialog();
            dic.ShowDialog();
            var files = dic.OpenFiles();

            
            foreach(var item in files)
            {

                var src = new StringBuilder();

                // 解析对应的值
                var fields = await item.QueryAsync<Fields>();

                foreach(var field in fields)
                {
                    if (field.Annotation!=null)
                    {
                        src.AppendLine("/// <summary>")
                            .Append("/// ")
                            .AppendLine(field.Annotation)
                            .AppendLine("/// </summary>");
                    }

                    if (!string.IsNullOrWhiteSpace(field.Display)) { }

                }


                await File.WriteAllTextAsync(item., src.ToString());
            }
            // 拼接生成C#Model源文件


        }
    }
}
