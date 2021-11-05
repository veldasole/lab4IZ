using library.ViewModel;
using System;

namespace library.Model
{
    public class Book
    {
        public int Id { get; set; }
        public int AuthorId { get; set; }
        public int PublishId { get; set; }
        public string Title { get; set; }
        public string Code { get; set; }
        public int YearPublish { get; set; }
        public int CountPage { get; set; }
        public string Hardcover { get; set; }
        public string Abstract { get; set; }
        public bool Statuc { get; set; }

        public Book() { }
        public Book(int id, int authorId, int publishId, string title, string code,
            int yearPublish, int countPage, string hardcover, string bstract, bool statuc)
        {
            this.Id = id;
            this.AuthorId = authorId;
            this.PublishId = publishId;
            this.Title = title;
            this.Code = code;
            this.YearPublish = yearPublish;
            this.CountPage = countPage;
            this.Hardcover = hardcover;
            this.Abstract = bstract;
            this.Statuc = statuc;
        }
        public Book CopyFromBookDPO(BookDPO book)
        {
            AuthorViewModel vmAuthor = new AuthorViewModel();
            int authorId = 0;
            foreach (var a in vmAuthor.ListAuthor)
            {
                if (a.LastName == book.Author)
                {
                    authorId = a.Id;
                    break;
                }
            }
            PublishViewModel vmPublish = new PublishViewModel();
            int publishId = 0;
            foreach (var p in vmPublish.ListPublish)
            {
                if (p.NamePublish == book.Publish)
                {
                    publishId = p.Id;
                    break;
                }
            }
            if (authorId != 0)
            {
                this.Id = book.Id;
                this.AuthorId = authorId;
                this.PublishId = publishId;
                this.Title = book.Title;
                this.Code = book.Code;
                this.YearPublish = book.YearPublish;
                this.CountPage = book.CountPage;
                this.Hardcover = book.Hardcover;
                this.Abstract = book.Abstract;
                this.Statuc = book.Statuc;
            }
            return this;
        }

    }
}
