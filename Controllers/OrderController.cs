using biblioteka.Domain;
using biblioteka.Repository;
using Microsoft.AspNetCore.Mvc;

namespace biblioteka.Controllers
{
    [ApiController]
    [Route("/Order")]
    public class OrderController : ControllerBase
    {
        [HttpPut]
        public Order Create(Order Order)
        {
            Storage.OrderStorage.Create(Order);
            return Order;
        }

        [HttpGet]
        public Order Read(int OrderId)
        {
            return Storage.OrderStorage.Read(OrderId);
        }

        [HttpPost]
        public Order Update(int OrderId, Order newOrder)
        {
            return Storage.OrderStorage.Update(OrderId, newOrder);
        }

        [HttpDelete]
        public bool Delete(int OrderId)
        {
            return Storage.OrderStorage.DeleteOrderId); ;
        }
    }
}