using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstApp.Model
{
    [Table("Address")]
    public class Address
    {
        [Key]
        public int Id { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string HouseNumber { get; set; }
        public string FlatNumber { get; set; }
        public string Description { get; set; }
        public string PostCode { get; set; }
        public decimal Longtitude { get; set; }
        public decimal Latitude { get; set; }
    }
}
