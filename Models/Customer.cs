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
    // Customer models with unique ID as PK
    public class Customer
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime PurchaseDate { get; set; }

        // Navigation property to orders table
        public ICollection<Order> Orders { get; set; }
    }
}
