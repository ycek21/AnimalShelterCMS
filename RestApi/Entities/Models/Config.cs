using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Entities.Models
{
    public class Config
    {
        [Key]
        public string Key { get; set; }
        public string Value { get; set; }
        public DateTime ModifiedAt { get; set; }

        [ForeignKey("User")]
        public Guid ModifiedBy { get; set; }

        public User User { get; set; }

        public Config()
        {
            this.ModifiedAt = DateTime.Now;
        }
    }
}