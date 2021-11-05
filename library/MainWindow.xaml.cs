using System.Windows;
using library.View;

namespace library
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static int IdAuthor { get; set; }
        public static int IdPublish { get; set; }
        public static int IdBook { get; set; }
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Author_OnClick(object sender, RoutedEventArgs e)
        {
            WindowAuthor wAuthor = new WindowAuthor();
            wAuthor.Show();
        }
        private void Publish_OnClick(object sender, RoutedEventArgs e)
        {
            WindowPublish wPublish = new WindowPublish();
            wPublish.Show();
        }
        private void Book_OnClick(object sender, RoutedEventArgs e)
        {
            WindowBook wBook = new WindowBook();
            wBook.Show();
        }

        
    }
}
