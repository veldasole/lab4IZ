
using System.Windows;


namespace library.View
{
    /// <summary>
    /// Логика взаимодействия для WindowNewPublish.xaml
    /// </summary>
    public partial class WindowNewPublish : Window
    {
        public WindowNewPublish()
        {
            InitializeComponent();
        }
        private void BtSave_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }
    }
}
