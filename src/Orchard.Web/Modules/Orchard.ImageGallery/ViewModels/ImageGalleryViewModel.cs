using System.Collections.Generic;
using Orchard.ImageGallery.Models;
using Orchard.ImageGallery.Models.Plugins;

namespace Orchard.ImageGallery.ViewModels {
    public class ImageGalleryViewModel {
        public IEnumerable<ImageGalleryImage> Images { get; set; }

        public ImageGalleryPlugin ImageGalleryPlugin { get; set; }

        public int ThumbnailWidth { get; set; }

        public int ThumbnailHeight { get; set; }

      public string ImageGalleryName { get; set; }
    }
}