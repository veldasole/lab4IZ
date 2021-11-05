using library.Model;


namespace library.Helper
{
    class FindBook
    {
        int id;
        public FindBook(int id)
        {
            this.id = id;
        }
        public bool BookPredicate(Book book)
        {
            return book.Id == id;

        }

    }
}
