using System;
using System.IO;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Contracts;
using Microsoft.AspNetCore.Http;

namespace Service
{
    public class PhotoService : IPhotoService
    {


        private ILoggerManager _logger;

        public PhotoService(ILoggerManager logger)
        {
            _logger = logger;
        }

        public string UploadPhoto(IFormFile fileToUpload)
        {
            try
            {
                if (fileToUpload.Length > 0)
                {
                    var getExtension = fileToUpload.ContentType.Split('/');

                    var fileExtension = getExtension[1].ToString().ToUpper();

                    if (fileExtension != "JPG" && fileExtension != "JPEG" && fileExtension != "PNG")
                    {
                        throw new System.ArgumentOutOfRangeException("fileFromRequest extension is wrong");
                    }

                    var folderName = Path.Combine("Resources", "Images");
                    var parentPath = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).ToString(), "RestApi");
                    var pathToSave = Path.Combine(parentPath, folderName);

                    _logger.LogWarn(folderName.ToString());
                    _logger.LogWarn(parentPath.ToString());
                    _logger.LogWarn(pathToSave.ToString());


                    var checkIfDirExists = Directory.Exists(pathToSave);

                    if (checkIfDirExists == false)
                    {
                        Directory.CreateDirectory(pathToSave);
                    }

                    var fileName = ContentDispositionHeaderValue.Parse(fileToUpload.ContentDisposition).FileName.Trim('"');
                    var fullPath = Path.Combine(pathToSave, fileName);
                    var dbPath = Path.Combine(folderName, fileName);

                    _logger.LogWarn(fileName.ToString());
                    _logger.LogWarn(fullPath.ToString());
                    _logger.LogWarn(dbPath.ToString());
                    _logger.LogDebug("xd");



                    using (var stream = new FileStream(dbPath, FileMode.Create))
                    {
                        fileToUpload.CopyTo(stream);
                    }

                    return dbPath;

                }
                else
                {
                    return null;
                }
            }
            catch (System.Exception ex)
            {
                //decide what should be done here
                throw ex;
            }
        }
    }
}