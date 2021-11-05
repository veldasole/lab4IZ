using System.Windows;
using library.Helper;
using library.ViewModel;
using library.Model;
using System.Collections.Generic;
using System;
using System.Collections.ObjectModel;
using System.Linq;

namespace library.View
{
    /// <summary>
    /// Логика взаимодействия для WindowBook.xaml
    /// </summary>
    public partial class WindowBook : Window
    {
        private BookViewModel vmBook;
        private AuthorViewModel vmAuthor;
        private PublishViewModel vmPublish;
        private ObservableCollection<BookDPO> booksDPO;
        private List<Author> authors;
        private List<Publish> publishs;

        public WindowBook()
        {
            InitializeComponent();
            vmBook = new BookViewModel();
            vmAuthor = new AuthorViewModel();
            vmPublish = new PublishViewModel();
            authors = vmAuthor.ListAuthor.ToList();
            publishs = vmPublish.ListPublish.ToList();


            booksDPO = new ObservableCollection<BookDPO>();
            foreach (var book in vmBook.ListBook)
            {
                BookDPO b = new BookDPO();
                b = b.CopyFromBook(book);
                booksDPO.Add(b);
            }
            lvBook.ItemsSource = booksDPO;

        }
        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            WindowNewBook wnBook = new WindowNewBook
            {
                Title = "Новая книга",
                Owner = this
            };
            
            int maxIdBook = vmBook.MaxId() + 1;
            BookDPO bok = new BookDPO
            {
                Id = maxIdBook
            };
            wnBook.DataContext = bok;
            wnBook.CbAuthor.ItemsSource = authors;
            wnBook.CbPublish.ItemsSource = publishs;

            if (wnBook.ShowDialog() == true)
            {
                Author a = (Author)wnBook.CbAuthor.SelectedValue;
                Publish p = (Publish)wnBook.CbPublish.SelectedValue;
                bok.Author = a.LastName + " " + a.FirstName;
                bok.Publish = p.NamePublish;
                booksDPO.Add(bok);
                
                Book b = new Book();
                b = b.CopyFromBookDPO(bok);
                vmBook.ListBook.Add(b);
            }
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            WindowNewBook wnBook = new WindowNewBook
            {
                Title = "Редактирование данных",
                Owner = this
            };
            BookDPO bokDPO = (BookDPO)lvBook.SelectedValue;
            BookDPO tempBookDPO; // временный класс для редактирования
            if (bokDPO != null)
            {
                tempBookDPO = bokDPO.ShallowCopy();
                wnBook.DataContext = tempBookDPO;

                wnBook.CbAuthor.ItemsSource = authors;
                wnBook.CbPublish.ItemsSource = publishs;

                
                wnBook.CbAuthor.Text = tempBookDPO.Author;
                wnBook.CbPublish.Text = tempBookDPO.Publish;

                if (wnBook.ShowDialog() == true)
                {

                    Author a = (Author)wnBook.CbAuthor.SelectedValue;
                    bokDPO.Author = a.LastName + " " + a.FirstName;

                    Publish p = (Publish)wnBook.CbPublish.SelectedValue;
                    bokDPO.Publish = p.NamePublish;
                                     
                    bokDPO.Title = tempBookDPO.Title;
                    bokDPO.Code = tempBookDPO.Code;
                    bokDPO.YearPublish = tempBookDPO.YearPublish;
                    bokDPO.CountPage = tempBookDPO.CountPage;
                    bokDPO.Hardcover = tempBookDPO.Hardcover;
                    bokDPO.Abstract = tempBookDPO.Abstract;
                    bokDPO.Statuc = tempBookDPO.Statuc;

                    lvBook.ItemsSource = null;
                    lvBook.ItemsSource = booksDPO;
                   
                    FindBook finder = new FindBook(bokDPO.Id);
                    List<Book> listBook = vmBook.ListBook.ToList();
                    Book b = listBook.Find(new Predicate<Book>(finder.BookPredicate));
                    b = b.CopyFromBookDPO(bokDPO);
                }
            }
            else
            {
                MessageBox.Show("Необходимо выбрать книгу для редактированния",
                "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            BookDPO book = (BookDPO)lvBook.SelectedItem;
            if (book != null)
            {
                MessageBoxResult result = MessageBox.Show("Удалить данные по книге: \n"
                    + book.Title,
                "Предупреждение", MessageBoxButton.OKCancel, MessageBoxImage.Warning);
                if (result == MessageBoxResult.OK)
                {
                    // удаление данных в списке отображения данных
                    booksDPO.Remove(book);
                   
                    Book bok = new Book();
                    bok = bok.CopyFromBookDPO(book);
                    vmBook.ListBook.Remove(bok);
                }
            }
            else
            {
                MessageBox.Show("Необходимо выбрать данные по книге для удаления",
                    "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Warning);
            }

        }
    }
}
