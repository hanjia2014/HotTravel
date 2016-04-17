using System.ComponentModel.DataAnnotations;

namespace Orchard.ImageGallery.ViewModels {
    public class CreateGalleryViewModel {
        [Required]
        public string GalleryName { get; set; }
    }
}