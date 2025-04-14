using System.Collections.Generic;
using Entities.Models;

namespace Entities.DataTransferObjects
{
    public class AnimalTraitDto
    {
        public List<SizeDto> Sizes { get; set; }
        public List<ColorDto> Colors { get; set; }
        public List<AnimalTypeDto> AnimalTypes { get; set; }


        public AnimalTraitDto(List<SizeDto> sizes, List<ColorDto> colors, List<AnimalTypeDto> animalTypes)
        {
            Sizes = sizes;
            Colors = colors;
            AnimalTypes = animalTypes;
        }
    }
}