using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CRUD.Models
{
    [Table("Cities")]
    public class City
    {
        public City()
        {

        }
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        [Column("Postal Code")]
        public string PostalCode { get; set; }
    }
}