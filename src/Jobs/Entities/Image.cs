using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations;
using System.IO;

namespace Jobs.Entities {
    public class Image {
        public static Image FromFormFile(IFormFile formFile) {

            Image image = new Image();
            MemoryStream memoryStream = new MemoryStream();
            formFile.CopyTo(memoryStream);
            image.Data = memoryStream.ToArray();    
            return image;
        }
        public Image() { }
        [Key]
        public int Id { get; set; }
        public byte[] Data { get; set; }
        public string GetImageUrl() {
            string base64Data = Convert.ToBase64String(Data);
            string imageDataUrl = string.Format("data:image/jpg;base64, {0}", base64Data);
            return imageDataUrl;
        }
    }
}
