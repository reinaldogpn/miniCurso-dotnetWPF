using System.Windows;
using System.Windows.Controls;

namespace WPFTutorial.View.UserControls
{
    public partial class ClearableTextBox : UserControl
    {
        public ClearableTextBox()
        {
            InitializeComponent();
        }

        private string _placeholder;

        public string Placeholder
        {
            get { return _placeholder; }
            set 
            { 
                _placeholder = value; 

                // wrong way, do not do this!
                tbPlaceholder.Text = _placeholder;
                // OnPropertyChanged()
            }
        }


        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            txtInput.Clear();
            txtInput.Focus();
        }

        private void txtInput_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (string.IsNullOrEmpty(txtInput.Text))
            {
                tbPlaceholder.Visibility = Visibility.Visible;
            }
            else
            {
                tbPlaceholder.Visibility = Visibility.Hidden;
            }
        }
    }
}
