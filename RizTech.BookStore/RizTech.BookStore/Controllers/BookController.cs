using Microsoft.AspNetCore.Mvc;
using RizTech.BookStore.Models;
using RizTech.BookStore.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RizTech.BookStore.Controllers
{
    public class BookController : Controller
    {
        //public IActionResult Index()
        //{
        //    return View();
        //}
        private readonly BookRepository bookRepository = null;
        public BookController()
        {
            bookRepository = new BookRepository();
        }
        public List<BookModel> GetAllBooks()
        {
            return bookRepository.GetAllBooks();
        }
        public BookModel GetBook(int id)
        {
            return bookRepository.GetBookById(id);
        }
        public List<BookModel> SearchBook(string BookName, string AuthorName)
        {
            return bookRepository.SearchBook(BookName, AuthorName);
        }
    }
}
