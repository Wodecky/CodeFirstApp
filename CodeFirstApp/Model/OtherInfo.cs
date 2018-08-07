using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstApp.Model
{
    [Table("OtherInfo")]
    public class OtherInfo
    {
        public int Id { get; set; }
        public InfoTypes Type { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
    }
}
