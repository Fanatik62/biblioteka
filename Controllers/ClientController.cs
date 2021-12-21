using biblioteka.Domain;
using biblioteka.Repository;
using Microsoft.AspNetCore.Mvc;

namespace biblioteka.Controllers
{
    [ApiController]
    [Route("/Client")]
    public class ClientController : ControllerBase
    {
        [HttpPut]
        public Client Create(Client Client)
        {
            Storage.ClientStorage.Create(Client);
            return Client;
        }

        [HttpGet]
        public Client Read(int ClientId)
        {
            return Storage.ClientStorage.Read(ClientId);
        }

        [HttpPost]
        public Librarian Update(int ClientId, Client newClient)
        {
            return Storage.ClientStorage.Update(ClientId, newClient);
        }

        [HttpDelete]
        public bool Delete(int ClientId)
        {
            return Storage.ClientStorage.DeleteClientId); ;
        }
    }
}