using System.Windows;
using library.ViewModel;
using library.Model;

namespace library.Helper
{
    class FindPublish
    {
        int id;
        public FindPublish(int id)
        {
            this.id = id;
        }
        public bool PublishPredicate(Publish publish)
        {
            return publish.Id == id;
        }
    }
}
