using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;


namespace Entities.Models
{
    public class Fundraiser
    {
        public Guid Id { get; set; }
        public int Target { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime FinishDate { get; set; }

        [ForeignKey("User")]
        public string? UserId { get; set; }

        public User? User { get; set; }
        public ICollection<Donation> Donations { get; set; }
    }
}