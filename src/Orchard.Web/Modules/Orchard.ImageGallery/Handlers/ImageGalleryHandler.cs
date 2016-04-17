using Orchard.ImageGallery.Models;
using Orchard.ContentManagement.Handlers;
using Orchard.Data;


namespace Orchard.ImageGallery.Handlers {
    public class ImageGalleryHandler : ContentHandler {
        public ImageGalleryHandler(IRepository<ImageGalleryRecord> repository) {
            Filters.Add(StorageFilter.For(repository));
        }
    }
}