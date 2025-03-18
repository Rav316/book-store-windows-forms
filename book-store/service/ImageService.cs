using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book_store.service
{
    internal class ImageService
    {
        public string SaveImage(string fileName)
        {
            string fileExtension = Path.GetExtension(fileName);
            string newFileName = $"{Guid.NewGuid()}{fileExtension}";
            string saveDirectory = @"..\..\..\Resources\Users";
            string savePath = Path.Combine(saveDirectory, newFileName);

            if(!Directory.Exists(savePath))
            {
                Directory.CreateDirectory(saveDirectory);
            }

            File.Copy(fileName, savePath, true);
            return savePath;
        }

        public void DeleteImage(string imagePath)
        {
            if(File.Exists(imagePath))
            {
                File.Delete(imagePath);
            }
        }
    }
}
