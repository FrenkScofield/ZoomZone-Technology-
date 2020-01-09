using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ZoomZone.Utilities
{
    public static class Utility
    {
        public static bool DeleteImgFromFolder(string root, string file,string intoFile ,string image)
        {
            
            string path = Path.Combine(root, file, intoFile, image);
            if (System.IO.File.Exists(path))
            {
                System.IO.File.Delete(path);
                return true;
            }
            return false;
        }
    }
}
