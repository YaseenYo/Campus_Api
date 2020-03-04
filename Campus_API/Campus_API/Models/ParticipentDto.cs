using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Campus_API.Models
{
    public class ParticipentDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Usn { get; set; }
        public string Sem { get; set; }
        public int PhoneNo { get; set; }
        public string EmailId { get; set; }
    }
}
