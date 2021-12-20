using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Partice.Models;
namespace Partice.Models
{
    public class DataContext:DbContext
    {
        public DataContext() : base("Partice") { }
        public DbSet<Contact> Contacts { get; set; }
    }
}