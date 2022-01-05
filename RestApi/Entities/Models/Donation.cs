using System;
using System.ComponentModel.DataAnnotations.Schema;


namespace Entities.Models
{
    public class Donation
    {
        public Guid Id { get; set; }
        public DateTime Date { get; set; }
        public int Amount { get; set; }

        [ForeignKey("User")]
        public string UserId { get; set; }

        [ForeignKey("Fundraiser")]
        public Guid FundraiserId { get; set; }

        public User User { get; set; }
        public Fundraiser Fundraiser { get; set; }
    }
}