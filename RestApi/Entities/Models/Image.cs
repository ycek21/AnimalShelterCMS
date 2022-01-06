using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace Entities.Models
{
    public class Image
    {
        public Guid Id { get; set; }
        public string Url { get; set; }
        public bool IsProfilePicture { get; set; }

        [ForeignKey("Animal")]
        [IgnoreDataMember]
        public Guid AnimalId { get; set; }

        [IgnoreDataMember]
        public Animal Animal { get; set; }
    }
}