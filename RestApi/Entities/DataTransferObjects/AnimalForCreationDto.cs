using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Entities.DataTransferObjects
{
    public class AnimalForCreationDto
    {
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Description { get; set; }
        public string Character { get; set; }
        public int Weight { get; set; }
        public bool Sex { get; set; }
        public int WalkLimit { get; set; }
        public Guid SizeId { get; set; }
        public Guid ColorId { get; set; }
        public Guid AnimalTypeId { get; set; }

    }
}