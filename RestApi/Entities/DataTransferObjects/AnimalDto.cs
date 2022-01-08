using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entities.Models;

namespace Entities.DataTransferObjects
{
    public class AnimalDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }

        public string Description { get; set; }
        public string Character { get; set; }
        public bool Sex { get; set; }
        public int Weight { get; set; }
        public int WalkLimit { get; set; }
        public int Views { get; set; }
        public bool IsDead { get; set; }
        public DateTime ModifiedAt { get; set; }
        public string ModifiedBy { get; set; }
        public string Size { get; set; }
        public string Color { get; set; }
        public string AnimalType { get; set; }
        public ICollection<Image> Images { get; set; }
        public ICollection<WalkForAnimalGet> Walks { get; set; }

    }
}