using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyFlight.Data
{
    public class Player
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        public string MyFlightscopeId { get; set; }

        public virtual ICollection<Bag> Bags { get; set; }

        public virtual ICollection<Club> Clubs { get; set; }

        public virtual ICollection<Ball> Balls { get; set; }

        public DateTime CreatedOn { get; set; }

        public DateTime LastUpdated { get; set; }

        public DateTime LastSynced { get; set; }
    }
}