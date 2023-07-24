using Ecommerce1.Data;
using Ecommerce1.Models;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ContactController : ControllerBase
    {
        private readonly ContactsAPIDbContext dbContext;
        public ContactController(ContactsAPIDbContext dbContext) {
            this.dbContext = dbContext;
        }
        [HttpGet]
        public IActionResult GetContacts()
        {
            //Since with DbSet in contactsApiDbContext we
            return Ok(dbContext.Contacts.ToList());
        }
        [HttpPost]
        public IActionResult AddContact(AddContactRequest addContactRequest)
        {
            var contact = new Contact()
            {
                //Here we are doing mapping between add 
                Id = Guid.NewGuid(),
                Address = addContactRequest.Address,
                Fullname = addContactRequest.Fullname,
                Email = addContactRequest.Email,
                Phone = addContactRequest.Phone,
            };
            dbContext.Contacts.Add(contact); //We can also use async but for that we have use await.
            dbContext.SaveChanges(); //We have to save changes to see them //With async keyword the Iaction has be wrapped inside a task
            //using dbContext we can talk to our table.
            return Ok(contact);
        }
    }
}
