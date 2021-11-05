using System;
using System.Collections.ObjectModel;
using library.Model;


namespace library.ViewModel
{
    public class PublishViewModel
    {
        public ObservableCollection<Publish> ListPublish { get; set; } =
        new ObservableCollection<Publish>();
        public PublishViewModel()
        {
            this.ListPublish.Add(
            new Publish
            {
                Id = 1,
                NamePublish = "АСТ",
                Address = "129085, г. Москва, б-р Звёздный, 21, стр. 1, ком. 705, ПОМ.",
                Site = "https://ast.ru/"
            });
            this.ListPublish.Add(
            new Publish
            {
                Id = 2,
                NamePublish = "Эксмо",
                Address = "город Москва улица Зорге дом 1 строение 1 этаж 20 КАБ 2013.",
                Site = "https://eksmo.ru/"
            });
        }

        public int MaxId()
        {
            int max = 0;
            foreach (var a in this.ListPublish)
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
