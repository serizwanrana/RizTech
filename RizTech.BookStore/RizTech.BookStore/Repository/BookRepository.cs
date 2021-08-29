using RizTech.BookStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RizTech.BookStore.Repository
{
    public class BookRepository
    {
        public List<BookModel> GetAllBooks()
        {
            return DataSource();
        }

        public BookModel GetBookById(int id)
        {
            return DataSource().Where(x => x.Id == id).FirstOrDefault();
        }

        public List<BookModel> SearchBook(string title, string author)
        {
            return DataSource().Where(x=>x.Title.Contains(title) || x.Author.Contains(author)).ToList();
        }

        private List<BookModel> DataSource()
        {
            return new List<BookModel>()
            {
                new BookModel(){Id= 1, Title = "Java", Author = "Rizwan Rana"},
                new BookModel(){Id= 2, Title = "Css", Author = "Muhammad"},
                new BookModel(){Id= 3, Title = "Computer", Author = "Sajjad"},
                new BookModel(){Id= 4, Title = "Math", Author = "Bilal"},

            };
        }
    }
}
