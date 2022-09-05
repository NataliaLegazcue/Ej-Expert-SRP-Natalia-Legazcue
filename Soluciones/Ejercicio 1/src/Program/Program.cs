using System;

namespace SRP
{

    class Program
    {
        static void Main()
        {
            Book book1 = new Book("Design Patterns","Erich Gamma & Others","001-034");
            Book book2 = new Book("Pro C#","Troelsen","001-035"); 

            Ubicacion ubicacion1 = new Ubicacion (book, book, book, "AA", "352");
            Ubicacion ubicacion2 = new Ubicacion(book, book, book, "AB", "552");
            
        }
    }
}