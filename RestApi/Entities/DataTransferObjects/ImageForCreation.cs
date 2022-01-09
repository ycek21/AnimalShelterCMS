using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Entities.DataTransferObjects
{
    public class ImageForCreation
    {
        public string Url { get; set; }
        public bool IsProfilePicture { get; set; }
        public Guid AnimalId { get; set; }

        public ImageForCreation(string url, bool isProfilePicture, Guid animalId)
        {
            Url = url;
            IsProfilePicture = isProfilePicture;
            AnimalId = animalId;
        }
    }
}