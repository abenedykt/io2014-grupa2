using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sklep
{ 
    public class Zamowienie
    {
        Klient[] clients = new Klient[]
        {
            new Klient { Id = 1, Imie = "Jan", Nazwisko = "Nowak", Mail = "jnowak@gmail.com", Login = "Jnowak", Password = "qwerty123", Adres = "Jutrzenki 123, 43-300 Bielsko-Biala"},
            new Klient { Id = 2, Imie = "Adam", Nazwisko = "Kowalski", Mail = "kowal12@gmail.com", Login = "kowal", Password = "costam1", Adres = "Lwowska 3, 43-300 Bielsko-Biala"},
            new Klient { Id = 3, Imie = "Monika", Nazwisko = "Adamska", Mail = "moniska452@buziaczek.pl", Login = "SweetMonia", Password = "lovesweetmonia", Adres = "Siewna 23/45, 43-300 Bielsko-Biala"},
            new Klient { Id = 4, Imie = "Anna", Nazwisko = "Kazimierska", Mail = "ankaz@tlen.pl", Login = "AnnKa", Password = "ak1245", Adres = "Słodka 45/21, 43-300 Bielsko-Biala"},
        };

        Produkt[] products = new Produkt[]  
        {  
            new Produkt { Id = 1, Nazwa = "Klawiatura", Kategoria = "Urzadzenia wskazujace", Cena = 15.5 },  
            new Produkt { Id = 2, Nazwa = "Mysz", Kategoria = "Urzadzenia wskazujace", Cena = 10.0 },  
            new Produkt { Id = 3, Nazwa = "Kamera", Kategoria = "Akcesoria", Cena = 35.8 }, 
            new Produkt { Id = 4, Nazwa = "Karta sieciowa", Kategoria = "Karty", Cena = 152.5 },
            new Produkt { Id = 5, Nazwa = "Karta graficzna", Kategoria = "Karty", Cena = 234.8 },
            new Produkt { Id = 6, Nazwa = "Monitor", Kategoria = "Monitory", Cena = 535.0 },
            new Produkt { Id = 7, Nazwa = "Glosniki", Kategoria = "Akcesoria", Cena = 35.8 },
            new Produkt { Id = 8, Nazwa = "Dysk", Kategoria = "Dyski", Cena = 178.90 },
            new Produkt { Id = 9, Nazwa = "Pendrive", Kategoria = "Pamiec przenosna", Cena = 44.9 },
        };

        public IEnumerable<Produkt> GetAllProducts()
        {
            return products;
        }

        Dostawa[] delivery = new Dostawa[]
        {
            new Dostawa { Id = 1, Typ = "List polecony", CenaDostawy = 5.5},
            new Dostawa { Id = 2, Typ = "List ekonomiczny", CenaDostawy = 3.5},
            new Dostawa { Id = 3, Typ = "List priorytetowy", CenaDostawy = 6.5},
            new Dostawa { Id = 4, Typ = "Kurier", CenaDostawy = 13.99},
            new Dostawa { Id = 5, Typ = "Paczkomat", CenaDostawy = 3.99},
        };
             
    
    }
}
