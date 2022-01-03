using System;
using System.ComponentModel.DataAnnotations.Schema;


namespace Entities.Models
{
    public class Image
    {
        public Guid Id { get; set; }
        public string Url { get; set; }
        public bool IsProfilePicture { get; set; }

        [ForeignKey("Animal")]
        public Guid AnimalId { get; set; }

        public Animal Animal { get; set; }
    }
}