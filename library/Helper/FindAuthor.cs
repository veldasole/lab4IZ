using System.Windows;
using library.ViewModel;
using library.Model;

namespace library.Helper
{
    class FindAuthor
    {
        int id;
        public FindAuthor(int id)
        {
            this.id = id;
        }
        public bool AuthorPredicate(Author author)
        {
            return author.Id == id;
        }
    }
}
