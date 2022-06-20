using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Entities.DataTransferObjects
{
    public class WalkForCreationDto
    {
        public Guid AnimalId { get; set; }
        public DateTime DateOfWalk { get; set; }
    }
}