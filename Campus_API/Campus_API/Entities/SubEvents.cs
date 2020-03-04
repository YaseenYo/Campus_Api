using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Campus_API.Entities
{
    public class SubEvents
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required(ErrorMessage = "Specify a Proper Event name")]
        [MaxLength(20)]
        public string Name { get; set; }
        public float EntryFee { get; set; }

        [MaxLength(200)]
        public string Description { get; set; }

        [Required(ErrorMessage = "Declare a proper Hostname")]
        [MaxLength(20)]
        public string HostName { get; set; }
        public string PhotoName { get; set; }

        [ForeignKey("EventId")]
        public Event Event { get; set; }
        public int EventId { get; set; }

    }
}



















