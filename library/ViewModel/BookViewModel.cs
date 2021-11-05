using System;
using System.Collections.ObjectModel;
using library.Model;

namespace library.ViewModel
{
    class BookViewModel
    {
        public ObservableCollection<Book> ListBook { get; set; } =
        new ObservableCollection<Book>();
        public BookViewModel()
        {
            this.ListBook.Add(
            new Book
            {
                Id = 1,
                AuthorId = 1,
                PublishId = 1,
                Title = "Евгений Онегин",
                Code = "978-5-17-136987-3",
                YearPublish = 2021,
                CountPage = 352,
                Hardcover = "Мягкий",
                Abstract = "Пронзительная любовная история, драматические повороты сюжета, " +
                "\nтонкий психологизм персонажей, детальное описание быта и нравов той эпохи",
                Statuc = false
            });
            this.ListBook.Add(
            new Book
            {
                Id = 2,
                AuthorId = 2,
                PublishId = 1,
                Title = "Мертвые души",
                Code = "978-5-17-087889-5",
                YearPublish = 2021,
                CountPage = 352,
                Hardcover = "Мягкий",
                Abstract = "Никому до Гоголя и после него не удавалось так ярко и остро описать пороки и слабости " +
                "\nрусского человека, так живо и правдиво отразить важнейшие для России проблемы.",
                Statuc = true
            });
            this.ListBook.Add(
            new Book
            {
                Id = 3,
                AuthorId = 2,
                PublishId = 1,
                Title = "Тарас Бульба",
                Code = "978-5-04-114097-7",
                YearPublish = 2021,
                CountPage = 288,
                Hardcover = "Твердый ",
                Abstract = " Главная тема произведения — противостояние Запорожской Сечи и Речи Посполитой; главный герой, " +
                "\nТарас Бульба — истинный патриот, мудрый полководец и любящий отец, переживающий глубокую личную драму.",
                Statuc = true
            });

        }
        public int MaxId()
        {
            int max = 0;
            foreach (var b in this.ListBook)
            {
                if (max < b.Id)
                {
                    max = b.Id;
                };
            }
            return max;
        }
    }
}
