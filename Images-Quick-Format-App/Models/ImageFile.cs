using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Images_Quick_Format_App.Models
{
    public partial class ImageFile
    {
        public ImageFile() { }
        public int _no { get; set; } = 0;
        public string _imageName { get; set; } = null;
        public string _imagePath { get; set; } = null;
        public string _imageType { get; set; } = null;
        public string _imageSize { get; set; } = null;
    }
}
