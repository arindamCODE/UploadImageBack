using System;
using Microsoft.AspNetCore.Http;

namespace UploadImageBack.Models
{
    public class FileUploadViewModel
    {
       public IFormFile File { get; set; }
       public long Size { get; set; }
       public int Width 
    }
}