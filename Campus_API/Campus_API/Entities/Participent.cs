using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Campus_API.Entities
{
    public class Participent
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

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
