
using System.Windows;
using library.ViewModel;
using library.Model;

namespace library.View
{
    /// <summary>
    /// Логика взаимодействия для WindowAuthor.xaml
    /// </summary>
    public partial class WindowAuthor : Window
    {
        AuthorViewModel vmAuthor;

        public WindowAuthor()
        {
            InitializeComponent();
            vmAuthor = new AuthorViewModel();
            lvAuthor.ItemsSource = vmAuthor.ListAuthor;
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            WindowNewAuthor wnAuthor = new WindowNewAuthor
            {
                Title = "Новый автор",
                Owner = this
            };
            
            int maxIdAuthor = vmAuthor.MaxId() + 1;
            Author author = new Author
            {
                Id = maxIdAuthor
            };
            wnAuthor.DataContext = author;
            if (wnAuthor.ShowDialog() == true)
            {
                vmAuthor.ListAuthor.Add(author);
            }
        }
        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            WindowNewAuthor wnAuthor = new WindowNewAuthor
            {
                Title = "Редактирование автора",
                Owner = this
            };
            Author author = lvAuthor.SelectedItem as Author;
            if (author != null)
            {
                Author tempAuthor = author.ShallowCopy();
                wnAuthor.DataContext = tempAuthor;
                if (wnAuthor.ShowDialog() == true)
                {
                    // сохранение данных
                    author.FirstName = tempAuthor.FirstName;
                    author.LastName = tempAuthor.LastName;
                    lvAuthor.ItemsSource = null;
                    lvAuthor.ItemsSource = vmAuthor.ListAuthor;
                }
            }
            else
            {
                MessageBox.Show("Необходимо выбрать автора для редактированния",
                "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            Author author = (Author)lvAuthor.SelectedItem;
            if (author != null)
            {
                MessageBoxResult result = MessageBox.Show("Удалить данные по автору: " +
                author.LastName, "Предупреждение", MessageBoxButton.OKCancel,
                MessageBoxImage.Warning);
                if (result == MessageBoxResult.OK)
                {
                    vmAuthor.ListAuthor.Remove(author);
                }
            }
            else
            {
                MessageBox.Show("Необходимо выбрать автора для удаления",
                "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
    }
}
