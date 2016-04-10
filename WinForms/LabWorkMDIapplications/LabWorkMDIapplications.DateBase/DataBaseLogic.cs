using LabWorkMDIapplications.DateBase.Interface;
using System.Collections.Generic;
using System.Linq;

namespace LabWorkMDIapplications.DateBase
{
    public class DataBaseLogic : IRepository
    {
        private BooksDBEntities db;
        private int CountIdAutor;
        private int CountIdPubHouse;
        private int CountIdBook;

        public DataBaseLogic()
        {
            db = new BooksDBEntities();
            CountIdAutor = 0;
            CountIdPubHouse = 0;
            CountIdBook = 0;
        }

        public void AddAutor(string fName, string lName)
        {
            Autor autor = new Autor()
            {
                IdAutor = this.CountIdAutor,
                FName = fName,
                LName = lName,
            };
            db.Autor.Add(autor);
            ++CountIdAutor;
            SaveDB();
        }

        public void AddBook(string nameBook, int namPages, int idAutor, int idPubHouse)
        {
            Book book = new Book()
            {
                IdBook = this.CountIdBook,
                NameBook = nameBook,
                NamPages = namPages,
                IdAutor = idAutor,
                IdPublishingHouse = idPubHouse,
            };
            db.Book.Add(book);
            ++CountIdBook;
            SaveDB();
        }

        public void AddPublishingHouse(string NamePubHouse)
        {
            PublishingHouseSet pubHouse = new PublishingHouseSet()
            {
                IdPublishingHouse = CountIdPubHouse,
                Name = NamePubHouse,
            };

            db.PublishingHouseSet.Add(pubHouse);
            ++CountIdPubHouse;
            SaveDB();
        }

        public void SaveDB()
        {
            db.SaveChanges();
        }

        public ICollection<Book> ShowAllBooks()
        {
            return db.Book.ToList();
        }
    }
}
