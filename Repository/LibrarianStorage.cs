using biblioteka.Domain;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace biblioteka.Repository
{
    public class LibrarianStorage
    {
        private Dictionary<int, Librarian> Librarians { get; } = new Dictionary<int, Librarian>();
        //private SqlConnection Connection { get; } = new SqlConnection("Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password=myPassword;");
        //public LibrarianStorage() => Connection.Open();

        public void Create(Librarian Librarian)
        {
            Librarians.Add(Librarian.LibrarianId, Librarian);
            //var command = Connection.CreateCommand();
            //command.CommandText = "SELECT * FROM .....";
            //command.ExecuteNonQuery
            //command.ExecuteReader
            //command.ExecuteScalar
        }

        public Librarian Read(int LibrarianId)
        {
            return Librarians[LibrarianId];
        }

        public Librarian Update(int LibrarianId, Librarian newLibrarian)
        {
            Librarians[LibrarianId] = newLibrarian;
            return Librarians[LibrarianId];
        }

        public bool Delete(int LibrarianId)
        {
            return Librarians.Remove(LibrarianId);
        }
    }
}