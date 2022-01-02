using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    public class Walk
    {
        public Guid Id { get; set; }
        public DateTime Date { get; set; }
        public bool Accepted { get; set; }

        [ForeignKey("Animal")]
        public Guid AnimalId { get; set; }
        [ForeignKey("User")]
        public Guid UserId { get; set; }

        public Animal Animal { get; set; }
        public User User { get; set; }
    }
}