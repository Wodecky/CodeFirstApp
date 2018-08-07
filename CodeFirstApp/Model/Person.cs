using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstApp.Model
{
    [Table("Person")]
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [Column(TypeName ="date")]
        public DateTime? BirthDay { get; set; }
        [Column(TypeName ="datetime2")]
        public DateTime CreationTime { get; set; }

        public virtual IList<PhoneEntry> PhoneEntries { get; set; }

        public IList<Address> Addresses { get; set; }

        public IList<OtherInfo> OtherInfos { get; set; }

    }
}
