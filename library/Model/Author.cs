using System;

namespace library.Model
{
    public class Author
    {
        public int Id {get; set;}
        public string LastName { get; set; }
        public string FirstName { get; set; }

        public Author() { }
        public Author(int id, string lastName, string firstName) 
        {
            this.Id = id;
            this.LastName = lastName;
            this.FirstName = firstName;

        }
        public Author ShallowCopy()
        {
            return (Author)this.MemberwiseClone();
        }

    }
}
 