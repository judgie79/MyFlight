using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyFlight.Data
{
    public class Club
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] 
        public Guid Id { get; set; }

        public string MyFlightscopeId { get; set; }

        public string Name { get; set; }

        public string Brand { get; set; }

        public ClubType ClubType { get; set; }

        public ShaftType ShaftType { get; set; }

        public ShaftFlex Flex { get; set; }

        public decimal Loft { get; set; }

        public string SpecializedClubType { get; set; }

        public string Model { get; set; }

        public string Photo { get; set; }

        public string Description { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime CreatedOn { get; set; }

        public DateTime LastUpdated { get; set; }

        public DateTime LastSynced { get; set; }
    }
}