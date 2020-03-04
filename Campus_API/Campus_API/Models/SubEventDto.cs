using Campus_API.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Campus_API.Models
{
    public class SubEventDto
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public float EntryFee { get; set; }
        public string Description { get; set; }
        public string HostName { get; set; }
        public string PhotoName { get; set; }
    }
}
