using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entities.Models;

namespace Entities.DataTransferObjects
{
    public class AnimalForUserWalkDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public ICollection<Image> Images { get; set; }
    }
}