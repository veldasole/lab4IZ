
using System.Windows;
using library.ViewModel;
using library.Model;

namespace library.View
{
    /// <summary>
    /// Логика взаимодействия для WindowPublish.xaml
    /// </summary>
    public partial class WindowPublish : Window
    {
        PublishViewModel vmPublish;
        public WindowPublish()
        {
            InitializeComponent();
            vmPublish = new PublishViewModel();
            lvPublish.ItemsSource = vmPublish.ListPublish;
        }
        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            WindowNewPublish wnPublish = new WindowNewPublish
            {
                Title = "Новое издательство",
                Owner = this
            };
            
            int maxIdPublish = vmPublish.MaxId() + 1;
            Publish publish = new Publish
            {
                Id = maxIdPublish
            };
            wnPublish.DataContext = publish;
            if (wnPublish.ShowDialog() == true)
            {
                vmPublish.ListPublish.Add(publish);
            }
        }
        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            WindowNewPublish wnPublish = new WindowNewPublish
            {
                Title = "Редактирование издательства",
                Owner = this
            };
            Publish publish = lvPublish.SelectedItem as Publish;
            if (publish != null)
            {
                Publish tempPublish = publish.ShallowCopy();
                wnPublish.DataContext = tempPublish;
                if (wnPublish.ShowDialog() == true)
                {
                    // сохранение данных
                    publish.NamePublish = tempPublish.NamePublish;
                    publish.Address = tempPublish.Address;
                    publish.Site = tempPublish.Site;
                    lvPublish.ItemsSource = null;
                    lvPublish.ItemsSource = vmPublish.ListPublish;
                }
            }
            else
            {
                MessageBox.Show("Необходимо выбрать издательство для редактированния",
                "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            Publish publish = (Publish)lvPublish.SelectedItem;
            if (publish != null)
            {
                MessageBoxResult result = MessageBox.Show("Удалить данные по издатеельству: " +
                publish.NamePublish, "Предупреждение", MessageBoxButton.OKCancel,
                MessageBoxImage.Warning);
                if (result == MessageBoxResult.OK)
                {
                    vmPublish.ListPublish.Remove(publish);
                }
            }
            else
            {
                MessageBox.Show("Необходимо выбрать издательство для удаления",
                "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
    } 
}
       
    
