using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyFlight.Data
{
    public class Bag
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] 
        public Guid Id { get; set; }

        public string MyFlightscopeId { get; set; }

        public string Model { get; set; }
        
        public string Brand { get; set; }

        public BagType BagType { get; set; }
        
        public virtual ICollection<Club> Clubs { get; set; }

        public virtual ICollection<Ball> Balls { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime CreatedOn { get; set; }

        public DateTime LastUpdated { get; set; }

        public DateTime LastSynced { get; set; }

        public bool IsDefault { get; set; }
    }
}