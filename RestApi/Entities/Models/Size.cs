using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Entities.Models
{
    public class Size
    {
        public Guid Id { get; set; }

        [MaxLength(60)]
        public string Value { get; set; }


        public ICollection<Animal> Animals { get; set; }
    }
}