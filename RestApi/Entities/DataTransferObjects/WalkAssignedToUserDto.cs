using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entities.Models;

namespace Entities.DataTransferObjects
{
    public class WalkAssignedToUserDto
    {
        public Guid Id { get; set; }
        public DateTime Date { get; set; }
        public string AnimalName { get; set; }
        public string AnimalProfileImageUrl { get; set; }
    }
}