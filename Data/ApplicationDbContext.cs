/*
 * Duy Tan Vu
 * Book Store project for Lab 5, Comm Activity 5 & Lab 06
 * Date Created: December 9, 2020
 */

using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OshawaBookStore.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace OshawaBookStore.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // Create 3 tables
        public DbSet<Book> Books { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Customer> Customers { get; set; }
    }
}
