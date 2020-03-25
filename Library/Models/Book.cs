using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace Library.Models
{
    public class Book
    {
        public Book()
        {
            this.Authors = new HashSet<BookAuthor>();
            this.Copys = new HashSet<BookCopy>();
        }

        public int BookId { get; set; }
        public string Name { get; set; }
        public int PatronId { get; set; }
        public virtual ICollection<BookAuthor> Authors { get; set; }
        public virtual ICollection<BookCopy> Copys { get; set; }
        
    }
}