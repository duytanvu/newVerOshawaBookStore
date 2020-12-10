/*
 * Duy Tan Vu
 * Book Store project for Lab 5, Comm Activity 5 & Lab 06
 * Date Created: December 9, 2020
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OshawaBookStore.Models
{
    // Book models with unique ID as PK
    public class Book
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }

        // Navigation property to orders table
        public ICollection<Order> Orders { get; set; }
    }
}
