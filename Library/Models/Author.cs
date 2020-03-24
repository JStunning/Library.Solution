using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace Library.Models
{
    public class Author
    {
        public Author()
        {
            this.Books = new HashSet<BookAuthor>();
        }
        public int AuthorId {get; set;}
        public string AuthorName {get; set;}
        public int BookId { get; set; }
        public  ICollection<BookAuthor> Books { get; }
    }
}