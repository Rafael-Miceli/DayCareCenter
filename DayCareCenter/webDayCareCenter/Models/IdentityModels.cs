using System;
using System.Collections.Generic;
using Microsoft.AspNet.Identity.EntityFramework;

namespace webDayCareCenter.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public DateTime BirthDate { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Cpf { get; set; }
        public string Rg { get; set; }
        public string RgExpeditor { get; set; }
        public DateTime RgExpeditionDate { get; set; }

        //public List<Phone> Phones { get; set; }
    }

    public class Phone
    {
        public int Id { get; set; }
        public PhoneType PhoneType { get; set; }
        public string PhoneNumber { get; set; }   
    }

    public class PhoneType
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection")
        {
        }
    }
}