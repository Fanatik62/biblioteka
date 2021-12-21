using biblioteka.Domain;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace biblioteka.Repository
{
    public class BookStorage
    {
        private Dictionary<int, Book> Books { get; } = new Dictionary<int, Book>();
        //private SqlConnection Connection { get; } = new SqlConnection("Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password=myPassword;");
        //public BookStorage() => Connection.Open();

        public void Create(Book Book)
        {
            Books.Add(Book.BookId, Book);
            //var command = Connection.CreateCommand();
            //command.CommandText = "SELECT * FROM .....";
            //command.ExecuteNonQuery
            //command.ExecuteReader
            //command.ExecuteScalar
        }

        public Book Read(int BookId)
        {
            return Books[BookId];
        }

        public Book Update(int BookId, Book newBook)
        {
            Books[BookId] = newBook;
            return Books[BookId];
        }

        public bool Delete(int BookId)
        {
            return Books.Remove(BookId);
        }
    }
}