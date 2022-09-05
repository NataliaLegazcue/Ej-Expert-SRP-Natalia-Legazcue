using System;

namespace SRP
{
/*
Para cumplir con el principio SRP deberíamos haber una única razón para que cada clase cambie, 
por ejemplo una clase solo debe de cambiar cuando se agregan o eliminan libros 
(conteniendo la información de los mismos) y otra clase debe de cambiar solo cuando se asigna, 
modifica la ubicación de un libro (incluyendo un método para llamar al libro a ubicar) en lugar de tener 
toda esta información contenida en una única clase como sucede en el ejemplo 1.
*/
    public class Book
    {

        public string Title { get ; }
        public string Author { get ; }
        public string Code { get ;  }
        public string LibrarySector { get ; set; }
        public string LibraryShelve { get ; set; }

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

    }
}
