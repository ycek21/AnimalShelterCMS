using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

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
        public string UserId { get; set; }

        [IgnoreDataMember]
        public Animal Animal { get; set; }
        [IgnoreDataMember]
        public User User { get; set; }
    }
}