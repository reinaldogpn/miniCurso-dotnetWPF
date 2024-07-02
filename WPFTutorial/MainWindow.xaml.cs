using System.Windows;

namespace WPFTutorial
{
    public partial class MainWindow : Window
    {
        public bool IsRunning { get; set; } = true;
        public MainWindow()
        {
            InitializeComponent();

            tbHello.Text = "Hello World 2!";
            btnToggleRun.Content = "Run";
        }

        private void btnToggleRun_Click(object sender, RoutedEventArgs e)
        {
            if (IsRunning)
            {
                btnToggleRun.Content = "Running";
            }
            else
            {
                btnToggleRun.Content = "Stopped";
            }

            IsRunning = !IsRunning;
        }
    }
}