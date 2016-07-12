using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyFlight.Data
{
    public class Ball
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] 
        public Guid Id { get; set; }

        public string MyFlightscopeId { get; set; }

        public string Name { get; set; }

        public string Brand { get; set; }

        public string Model { get; set; }

        public string Photo { get; set; }

        public string Description { get; set; }

        public bool IsDeleted { get; set; }

        public bool IsRangeBall { get; set; }

        public DateTime CreatedOn { get; set; }

        public DateTime LastUpdated { get; set; }

        public DateTime LastSynced { get; set; }
    }
}