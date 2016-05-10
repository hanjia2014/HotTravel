using Orchard.MediaLibrary.Fields;
using System.Linq;

namespace HotTravel.Carousel.Models
{
    public class CarouselSlideViewModel
    {
        public string Title { get; set; }
        public string BodyText { get; set; }
        public string LinkedPage { get; set; }
        public string ImgUrl { get; set; }

        public CarouselSlideViewModel(CarouselSlidePart part)
        {
            Title = part.Title;
            BodyText = part.BodyText;
            LinkedPage = part.LinkedPage;
            var img = (MediaLibraryPickerField)part.Fields.FirstOrDefault(p => p.Name == "SlideImage");
            ImgUrl = img == null ? string.Empty : img.FirstMediaUrl;
        }
    }
}
