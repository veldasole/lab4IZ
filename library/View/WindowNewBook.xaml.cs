
using System.Windows;


namespace library.View
{
    /// <summary>
    /// Логика взаимодействия для WindowNewBook.xaml
    /// </summary>
    public partial class WindowNewBook : Window
    {
        public WindowNewBook()
        {
            InitializeComponent();
        }

        private void BtSave_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }
    }
    
}
