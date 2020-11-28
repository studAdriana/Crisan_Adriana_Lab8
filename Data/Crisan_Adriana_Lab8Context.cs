using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Crisan_Adriana_Lab8.Models;

namespace Crisan_Adriana_Lab8.Data
{
    public class Crisan_Adriana_Lab8Context : DbContext
    {
        public Crisan_Adriana_Lab8Context (DbContextOptions<Crisan_Adriana_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Crisan_Adriana_Lab8.Models.Book> Book { get; set; }

        public DbSet<Crisan_Adriana_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Crisan_Adriana_Lab8.Models.Category> Category { get; set; }

        public DbSet<Crisan_Adriana_Lab8.Models.BookCategory> BookCategory { get; set; }
    }
}
