using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CRUD.Models
{
    public class Person
    {
        public Person()
        {

        }
        [Key]
        public int Id { get; set; }
        [Column("First Name")]
        public string FirstName { get; set; }
        [Column("Last Name")]
        public string LastName { get; set; }
        public string Address { get; set; }
    }
}