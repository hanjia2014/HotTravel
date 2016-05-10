using Orchard.ContentManagement;
using Orchard.ContentManagement.Records;
using System.ComponentModel.DataAnnotations;

namespace HotTravel.Carousel.Models
{
    public class CarouselSlidePartRecord:ContentPartRecord
    {
        public virtual string Title { get; set; }
        public virtual string BodyText { get; set; }
        public virtual string LinkedPage { get; set; }
    }

    public class CarouselSlidePart : ContentPart<CarouselSlidePartRecord>
    {
        public string Title { get { return Retrieve(p => p.Title); } set { Store(p => p.Title, value); } }
        [StringLength(5000)]
        public string BodyText { get { return Retrieve(p => p.BodyText); } set { Store(p => p.BodyText, value); } }
        public string LinkedPage { get { return Retrieve(p => p.LinkedPage); } set { Store(p => p.LinkedPage, value); } }
    }
}
