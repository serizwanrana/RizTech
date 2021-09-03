using Microsoft.AspNetCore.Mvc;
using RizTech.BookStore.Models;
using RizTech.BookStore.Repository;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;

namespace RizTech.BookStore.Controllers
{
    public class BookController : Controller
    {
        private readonly BookRepository bookRepository = null;
        public BookController()
        {
            bookRepository = new BookRepository();
        }
        
        public ViewResult GetAllBooks()
        {
            var data = bookRepository.GetAllBooks();
            return View(data);
        }
        
        [Route("book-details/{id}", Name ="bookdetailsrout")]
        public ViewResult GetBook(int id)
        {
            var data = bookRepository.GetBookById(id);
            return View(data);
        }
        public List<BookModel> SearchBook(string BookName, string AuthorName)
        {
            return bookRepository.SearchBook(BookName, AuthorName);
        }

        public ViewResult AddNewBook()
        {
            return View();
        }
        [HttpPost]
        public ViewResult AddNewBook(BookModel bookModel)
        {
            return View();
        }
    }
}
