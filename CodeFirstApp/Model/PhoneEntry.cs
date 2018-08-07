using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstApp.Model
{
    [Table("PhoneEntry")]
    public class PhoneEntry
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(20)]
        public string PhoneNumber { get; set; }

        [MaxLength(5)]
        public string Prefix { get; set; }

        public string Description { get; set; }

        [ForeignKey("OwnerId")]
        public virtual Person Owner { get; set; }

        public int OwnerId { get; set; }
    }
}
