using book_store.database.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book_store.util
{
    internal class ImageUtils
    {
        public static Image GetImageByPath(string? imagePath)
        {
            if (imagePath != null && !imagePath.Equals(""))
            {
                return Image.FromFile(imagePath);
            } else
            {
                return Image.FromFile(@"..\..\..\Resources\Books\book.png");
            }
        }
    }
}
