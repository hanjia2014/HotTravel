using System.Collections.Generic;
using Orchard.ImageGallery.Models;

namespace Orchard.ImageGallery.ViewModels {
    public class ImageGalleryImagesViewModel {
        public IEnumerable<ImageGalleryImage> Images { get; set; }

        public string ImageGalleryName { get; set; }
    }
}