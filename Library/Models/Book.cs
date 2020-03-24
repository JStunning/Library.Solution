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
            this.Departments = new List<Department>();
        }

        public int BookId { get; set; }
        public string Name { get; set; }
        public string EnrollmentDate {get; set;}
        public virtual ICollection<BookAuthor> Authors { get; set; }
        public virtual ICollection<Department> Departments { get; set; }

        
    }
}