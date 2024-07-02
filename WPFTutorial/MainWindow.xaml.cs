using System.Collections;
using System.Windows;

namespace WPFTutorial
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            lvEntries.Items.Add("a");
            lvEntries.Items.Add("b");
            lvEntries.Items.Add("c");
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtEntry.Text))
            {
                lvEntries.Items.Add(txtEntry.Text);
            }

            txtEntry.Clear();
            txtEntry.Focus();
        }

        private void btnDel_Click(object sender, RoutedEventArgs e)
        {
            var items = lvEntries.SelectedItems;

            var result = MessageBox.Show($"Are you sure you want to delete {items.Count} items?", "Sure?", MessageBoxButton.YesNo);
            if (result == MessageBoxResult.Yes)
            {
                var itemsList = new ArrayList(items);
                foreach (var item in itemsList)
                {
                    lvEntries.Items.Remove(item);
                }
            }
        }

        private void btnClr_Click(object sender, RoutedEventArgs e)
        {
            lvEntries.Items.Clear();
        }
    }
}