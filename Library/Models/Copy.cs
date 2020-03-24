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
        }
        public int CopyId {get; set;}
        public string CopyNumber {get; set;}
        public  ICollection<Checkout> Patrons { get; }
    }
}