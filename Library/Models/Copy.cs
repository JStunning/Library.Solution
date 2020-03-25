using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace Library.Models
{
    public class Copy
    {
        public Copy()
        {
            this.Patrons = new HashSet<Checkout>();
            this.Books = new HashSet<BookCopy>();
        }
        public int CopyId {get; set;}
        public int BookId {get; set;}
        public int PatronId {get; set;}
        public string CopyNumber {get; set;}
        public string CopyDueDate {get; set;}
        public  ICollection<Checkout> Patrons { get; }
        public  ICollection<BookCopy> Books { get; }
    }
}