using biblioteka.Domain;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace biblioteka.Repository
{
    public class OrderStorage
    {
        private Dictionary<int, Order> Orders { get; } = new Dictionary<int, Order>();
        //private SqlConnection Connection { get; } = new SqlConnection("Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password=myPassword;");
        //public OrderStorage() => Connection.Open();

        public void Create(Order Order)
        {
            Orders.Add(Order.OrderId, Order);
            //var command = Connection.CreateCommand();
            //command.CommandText = "SELECT * FROM .....";
            //command.ExecuteNonQuery
            //command.ExecuteReader
            //command.ExecuteScalar
        }

        public Order Read(int OrderId)
        {
            return Orders[OrderId];
        }

        public Order Update(int OrderId, Order newOrder)
        {
            Orders[OrderId] = newOrder;
            return Orders[OrderId];
        }

        public bool Delete(intOrderId)
        {
            return Orders.Remove(OrderId);
        }
    }
}