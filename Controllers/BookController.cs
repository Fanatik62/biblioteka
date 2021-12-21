using biblioteka.Domain;
using biblioteka.Repository;
using Microsoft.AspNetCore.Mvc;

namespace biblioteka.Controllers
{
    [ApiController]
    [Route("/Book")]
    public class BookController : ControllerBase
    {
        [HttpPut]
        public Book Create(Book Book)
        {
            Storage.BookStorage.Create(Book);
            return Book;
        }

        [HttpGet]
        public Book Read(int BookId)
        {
            return Storage.BookStorage.Read(BookId);
        }

        [HttpPost]
        public Book Update(int BookId, Book newBook)
        {
            return Storage.BookStorage.Update(BookId, newBook);
        }

        [HttpDelete]
        public bool Delete(int BookId)
        {
            return Storage.BookStorage.DeleteBookId); ;
        }
    }
}