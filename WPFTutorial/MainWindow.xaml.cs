using System.Windows;
using WinForms = System.Windows.Forms;

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
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.InitialDirectory = "C:\\Users\\Reinaldo\\source\\repos\\miniCurso-dotnetWPF\\WPFTutorial";
            WinForms.DialogResult result = dialog.ShowDialog();

            if(result == WinForms.DialogResult.OK)
            {
                string folder = dialog.SelectedPath;
            }
            else
            {
                // no directory selected
            }
        }
    }
}