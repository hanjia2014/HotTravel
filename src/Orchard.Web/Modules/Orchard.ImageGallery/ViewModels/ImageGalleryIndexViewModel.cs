using System.Collections.Generic;

namespace Orchard.ImageGallery.ViewModels {
    public class ImageGalleryIndexViewModel {
        public ImageGalleryIndexViewModel() {
            ImageGalleries = new List<Models.ImageGallery>();
        }

        public IEnumerable<Models.ImageGallery> ImageGalleries { get; set; }
    }
}