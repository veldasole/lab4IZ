
using System.Windows;


namespace library.View
{
    /// <summary>
    /// Логика взаимодействия для WindowNewAuthor.xaml
    /// </summary>
    public partial class WindowNewAuthor : Window
    {
        public WindowNewAuthor()
        {
            InitializeComponent();
        }
        private void BtSave_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }
    }
}
