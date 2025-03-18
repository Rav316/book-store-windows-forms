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
        public static Image GetBookImageByPath(string? imagePath)
        {
            if (imagePath != null && !imagePath.Equals(""))
            {
                return Image.FromFile(imagePath);
            } else
            {
                return Image.FromFile(@"..\..\..\Resources\Images\book.png");
            }
        }

        public static Image GetUserAvatarByPath(string? imagePath)
        {
            if(imagePath != null && !imagePath.Equals(""))
            {
                return Image.FromFile(imagePath);
            } else
            {
                return Image.FromFile(@"..\..\..\Resources\Images\avatar.png");
            }
        }
    }
}
