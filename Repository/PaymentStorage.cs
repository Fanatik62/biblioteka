using biblioteka.Domain;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace biblioteka.Repository
{
    public class PaymentStorage
    {
        private Dictionary<int, Payment> Payments { get; } = new Dictionary<int, Payment>();
        //private SqlConnection Connection { get; } = new SqlConnection("Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password=myPassword;");
        //public AdminStorage() => Connection.Open();

        public void Create(Client Client)
        {
            Payments.Add(Payment.PaymentId, Payment);
            //var command = Connection.CreateCommand();
            //command.CommandText = "SELECT * FROM .....";
            //command.ExecuteNonQuery
            //command.ExecuteReader
            //command.ExecuteScalar
        }

        public Payment Read(int PaymentId)
        {
            return Payments[PaymentId];
        }

        public Payment Update(int PaymentId, Payment newPayment)
        {
            Payments[PaymentId] = newPayment;
            return Payments[PaymentId];
        }

        public bool Delete(int PaymentId)
        {
            return Payments.Remove(PaymentId);
        }
    }
}