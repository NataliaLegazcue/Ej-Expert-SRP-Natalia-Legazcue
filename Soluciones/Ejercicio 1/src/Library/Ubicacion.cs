using System;

namespace SRP
{
    public class Ubicacion
    {
       public Book(String title, String author, String code)
        {
            this.Title = title;
            this.Author = author;
            this.Code = code;
        }
        public void ShelveBook(String sector, String shelve)
        {
            this.LibrarySector = sector;
            this.LibraryShelve = shelve;
        }
        private IList<Ubicacion> items = new List<Ubicacion>();
        public Ubicacion AddItem(Book title, Book author, Book code, String sector, String shelve)
        {
            Ubicacion item = new Ubicacion (title, author, code, sector, shelve);
            this.items.Add(item);
            return item;
        }
        public void RemoveItem(Ubicacion item)
        {
            this.items.Remove(item);
        }

    }
}