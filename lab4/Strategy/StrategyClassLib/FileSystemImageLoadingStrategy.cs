using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyClassLib
{
    public class FileSystemImageLoadingStrategy : IImageDisplayStrategy
    {
        public string Display(string href)
        {
            StringBuilder stringBuilder = new StringBuilder("Trying to find the image in the file system at: " + href + "\n");
            if (File.Exists(href))
            {
                stringBuilder.Append("Image found in the file system, loading image");
            }
            else
            {
                stringBuilder.Append("Image not found in the file system");
            }
            return stringBuilder.ToString();
        }
    }
}