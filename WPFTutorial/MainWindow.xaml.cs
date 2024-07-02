using Microsoft.Win32;
using System.Windows;

namespace WPFTutorial
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnFire_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "C# Source Files | *.cs";
            fileDialog.InitialDirectory = "C:\\Users\\Reinaldo\\source\\repos\\miniCurso-dotnetWPF\\WPFTutorial";
            fileDialog.Title = "Please, pick CS source file(s)...";
            fileDialog.Multiselect = true;
            
            bool? success = fileDialog.ShowDialog();
            
            if (success == true)
            {
                string[] paths = fileDialog.FileNames;
                string[] fileNames = fileDialog.SafeFileNames;
                string unifiedFileNames = "";

                foreach (string fileName in fileNames)
                {
                    unifiedFileNames += fileName + " | ";
                }

                tbInfo.Text = unifiedFileNames;
            }
            else
            {
                tbInfo.Text = "No file selected";
            }
        }
    }
}