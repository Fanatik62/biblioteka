using biblioteka.Domain;
using biblioteka.Repository;
using Microsoft.AspNetCore.Mvc;

namespace biblioteka.Controllers
{
    [ApiController]
    [Route("/Payment")]
    public class PaymentController : ControllerBase
    {
        [HttpPut]
        public Payment Create(Payment Payment)
        {
            Storage.PaymentStorage.Create(Payment);
            return Payment;
        }

        [HttpGet]
        public Payment Read(int PaymentId)
        {
            return Storage.PaymentStorage.Read(PaymentId);
        }

        [HttpPost]
        public Payment Update(int PaymentId, Payment newPayment)
        {
            return Storage.PaymentStorage.Update(PaymentId, newPayment);
        }

        [HttpDelete]
        public bool Delete(int PaymentId)
        {
            return Storage.PaymentStorage.DeletePaymentId); ;
        }
    }
}