using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    public class Animal
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        [MaxLength(1000)]
        public string Description { get; set; }
        [MaxLength(500)]
        public string Character { get; set; }
        public bool Sex { get; set; }
        public int Weight { get; set; }
        public int WalkLimit { get; set; }
        public int Views { get; set; }
        public bool IsDead { get; set; }
        public DateTime ModifiedAt { get; set; }

        [ForeignKey("Size")]
        public Guid SizeId { get; set; }
        [ForeignKey("Color")]
        public Guid ColorId { get; set; }
        [ForeignKey("AnimalType")]
        public Guid AnimalTypeId { get; set; }
        [ForeignKey("User")]
        public Guid ModifiedBy { get; set; }

        public Size Size { get; set; }
        public Color Color { get; set; }
        public AnimalType AnimalType { get; set; }
        public User User { get; set; }
        public ICollection<Walk> Walks { get; set; }
        public ICollection<AdoptionApplication> AdoptionApplications { get; set; }
        public ICollection<Image> Images { get; set; }


        public Animal()
        {
            this.ModifiedAt = DateTime.Now;
        }

    }
}