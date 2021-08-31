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
                new BookModel(){Id= 1, Title = "Java", Author = "Rizwan Rana", Description="This is the Description for Java book in detail and easy to read.", Category ="Programming", Language="English", TotalPages=134},
                new BookModel(){Id= 2, Title = "Css", Author = "Muhammad", Description="This is the Description for Css book in detail and easy to read.", Category ="Reading", Language="English", TotalPages=400},
                new BookModel(){Id= 3, Title = "Computer", Author = "Sajjad", Description="This is the Description for Computer book in detail and easy to read.", Category ="Development", Language="English", TotalPages=600},
                new BookModel(){Id= 4, Title = "Math", Author = "Bilal", Description="This is the Description for Math book in detail and easy to read.", Category ="Solving", Language="English", TotalPages=450},
                new BookModel(){Id= 5, Title = "Physics", Author = "Baber Ghauri", Description="This is the Description for Physics book in detail and easy to read.", Category ="Study", Language="English", TotalPages=200},
                new BookModel(){Id= 6, Title = "Chemistry", Author = "Arooba Traiq", Description="This is the Description for Chemistry book in detail and easy to read.", Category ="Practical", Language="English", TotalPages=340},


            };
        }
    }
}
