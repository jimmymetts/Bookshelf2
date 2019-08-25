using System;
using System.Collections.Generic;
using System.Text;
using Bookshelf2.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Bookshelf2.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public  DbSet<ApplicationUser> ApplicationUser { get; set; }
        public  DbSet<Author> Author { get; set; }
        public  DbSet<Book> Book { get; set; }
    }
}
