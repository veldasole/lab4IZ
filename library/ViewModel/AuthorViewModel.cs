using System;
using System.Collections.ObjectModel;
using library.Model;

namespace library.ViewModel
{
    public class AuthorViewModel
    {
        public ObservableCollection<Author> ListAuthor { get; set; } =
        new ObservableCollection<Author>();

        public AuthorViewModel()
        {
            this.ListAuthor.Add(
            new Author
            {
                Id = 1,
                LastName = "Пушкин",
                FirstName = "Александр"
            });
            this.ListAuthor.Add(
            new Author
            {
                Id = 2,
                LastName = "Гоголь",
                FirstName = "Николай"
            });
            this.ListAuthor.Add(
            new Author
            {
                Id = 3,
                LastName = "Толстой",
                FirstName = "Лев"
            });
            this.ListAuthor.Add(
            new Author
            {
                Id = 4,
                LastName = "Достоевский",
                FirstName = "Федор"
            });
            this.ListAuthor.Add(
            new Author
            {
                Id = 5,
                LastName = "Булгаков",
                FirstName = "Михаил"
            });
        }
        
            public int MaxId()
        {
            int max = 0;
            foreach (var a in this.ListAuthor)
            {
                if (max < a.Id)
                {
                    max = a.Id;
                };
            }
            return max;
        }
    }
}
