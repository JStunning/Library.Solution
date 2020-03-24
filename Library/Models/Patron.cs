using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace Library.Models
{
    public class Patron
    {
        public Patron()
        {
            this.Copys = new HashSet<Checkout>();
        }

        public int PatronId { get; set; }
        public string PatronName { get; set; }
        public virtual ICollection<Checkout> Copys { get; set; }
    }
}