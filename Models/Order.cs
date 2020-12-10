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
    // Order models with unique ID as PK
    public class Order
    {
        /*
         * EF automatically intesprets <navigation property name><primary key property name> as a foreign key. 
         * So BookID and CustomerID are FKs of order table.
         */
        public int ID { get; set; }
        public int BookID { get; set; }
        public int CustomerID { get; set; }
        public bool ExpressShipping { get; set; }

        // Navigation properties
        public Customer Customer { get; set; }
        public Book Book { get; set; }
    }
}
