using System.Collections.Generic;

namespace LabWorkMDIapplications.DateBase.Interface
{
    public interface IRepository
    {
        ICollection<Book> ShowAllBooks();
        void AddAutor(string FName, string LName);
        void AddPublishingHouse(string NamePubHouse);

        void AddBook(string NameBook, int NamPages, int IdAutor, int IdPubHouse);

    }
}
