using biblioteka.Domain;
using biblioteka.Repository;
using Microsoft.AspNetCore.Mvc;

namespace biblioteka.Controllers
{
    [ApiController]
    [Route("/Librarian")]
    public class LibrarianController : ControllerBase
    {
        [HttpPut]
        public Librarian Create(Librarian Librarian)
        {
            Storage.LibrarianStorage.Create(Librarian);
            return Librarian;
        }

        [HttpGet]
        public Librarian Read(int LibrarianId)
        {
            return Storage.LibrarianStorage.Read(LibrarianId);
        }

        [HttpPost]
        public Librarian Update(int LibrarianId, Librarian newLibrarian)
        {
            return Storage.LibrarianStorage.Update(LibrarianId, newLibrarian);
        }

        [HttpDelete]
        public bool Delete(int LibrarianId)
        {
            return Storage.LibrarianStorage.DeleteLibrarianId); ;
        }
    }
}