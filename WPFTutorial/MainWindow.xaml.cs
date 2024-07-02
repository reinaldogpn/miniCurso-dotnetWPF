using System.Windows;

namespace WPFTutorial
{
    public partial class MainWindow : Window
    {
        public bool IsRunning { get; set; } = true;
        public MainWindow()
        {
            InitializeComponent();
        }
    }
}