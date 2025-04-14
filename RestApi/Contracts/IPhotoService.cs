using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace Contracts
{
    public interface IPhotoService
    {
        string UploadPhoto(IFormFile fileToUpload);
    }
}