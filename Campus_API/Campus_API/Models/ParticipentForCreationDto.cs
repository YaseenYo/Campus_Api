using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Campus_API.Models
{
    public class ParticipentForCreationDto
    {
        [Required]
        [MaxLength(20)]
        public string Name { get; set; }

        [Required]
        public string Usn { get; set; }

        [Required]
        public string Sem { get; set; }

        [Required]
        public int PhoneNo { get; set; }

        [Required]
        public string EmailId { get; set; }
    }
}
