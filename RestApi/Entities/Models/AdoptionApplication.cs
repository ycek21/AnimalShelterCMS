using System;
using System.ComponentModel.DataAnnotations.Schema;


namespace Entities.Models
{
    public class AdoptionApplication
    {
        public Guid Id { get; set; }
        public DateTime Date { get; set; }
        public DateTime? AdoptionDate { get; set; }

        [ForeignKey("User")]
        public Guid UserId { get; set; }
        [ForeignKey("Animal")]
        public Guid AnimalId { get; set; }

        public User User { get; set; }
        public Animal Animal { get; set; }
    }
}