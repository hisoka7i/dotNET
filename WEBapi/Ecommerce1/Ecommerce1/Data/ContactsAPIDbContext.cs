using Ecommerce1.Models;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce1.Data
{
    //We will now add this into our services 
    public class ContactsAPIDbContext : DbContext
    {
        public ContactsAPIDbContext(DbContextOptions options) : base(options)
        {
        }

        //These properties will act as table for the core 
        public DbSet<Contact> Contacts { get; set; }
    }
}
