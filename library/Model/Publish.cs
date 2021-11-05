using System;

namespace library.Model
{
    public class Publish
    {
        public int Id { get; set; }
        public string NamePublish { get; set; }
        public string Address { get; set; }
        public string Site { get; set; }

        public Publish() { }
        public Publish(int id, string namePublish, 
            string address, string site) 
        {
            this.Id = id;
            this.NamePublish = namePublish;
            this.Address = address;
            this.Site = site;
        }
        public Publish ShallowCopy()
        {
            return (Publish)this.MemberwiseClone();
        }
    }
}
