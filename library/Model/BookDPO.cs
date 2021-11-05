using library.ViewModel;
using System;


namespace library.Model
{
    public class BookDPO
    {
        public int Id { get; set; }
        public string Author { get; set; }
        public string Publish { get; set; }
        public string Title { get; set; }
        public string Code { get; set; }
        public int YearPublish { get; set; }
        public int CountPage { get; set; }
        public string Hardcover { get; set; }
        public string Abstract { get; set; }
        public bool Statuc { get; set; }
        public BookDPO() { }
        public BookDPO(int id, string author, string publish, string title, string code,
            int yearPublish, int countPage, string hardcover, string bstract, bool statuc)
        {
            this.Id = id;
            this.Author = author;
            this.Publish = publish;
            this.Title = title;
            this.Code = code;
            this.YearPublish = yearPublish;
            this.CountPage = countPage;
            this.Hardcover = hardcover;
            this.Abstract = bstract;
            this.Statuc = statuc;
        }

        public BookDPO CopyFromBook(Book book)
        {
            BookDPO booDPO = new BookDPO();
            AuthorViewModel vmAuthor = new AuthorViewModel();
            string author = string.Empty;
            foreach (var a in vmAuthor.ListAuthor)
            {
                if (a.Id == book.AuthorId)
                {
                    author = a.LastName + " " + a.FirstName; ;
                    break;
                }
            }

            PublishViewModel vmPublish = new PublishViewModel();
            string publish = string.Empty;
            foreach (var p in vmPublish.ListPublish)
            {
                if (p.Id == book.PublishId)
                {
                    publish = p.NamePublish;
                    break;
                }
            }
            if (author != string.Empty)
            {
                booDPO.Id = book.Id;
                booDPO.Author = author;
                booDPO.Publish = publish;
                booDPO.Title = book.Title;
                booDPO.Code = book.Code;
                booDPO.YearPublish = book.YearPublish;
                booDPO.CountPage = book.CountPage;
                booDPO.Hardcover = book.Hardcover;
                booDPO.Abstract = book.Abstract;
                booDPO.Statuc = book.Statuc;
            }
            return booDPO;
        }
        public BookDPO ShallowCopy()
        {
            return (BookDPO)this.MemberwiseClone();
        }
    }
}
