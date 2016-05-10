using HotTravel.Carousel.Models;
using Orchard.ContentManagement;
using Orchard.ContentManagement.Drivers;

namespace HotTravel.Carousel.Drivers
{
    public class CarouselSlideDriver : ContentPartDriver<CarouselSlidePart>
    {
        //GET
        protected override DriverResult Editor(CarouselSlidePart part, dynamic shapeHelper)
        {
            return ContentShape("Parts_CarouselSlide_Edit", () => shapeHelper.EditorTemplate(TemplateName: "Parts/CarouselSlide",
                    Model: part,
                    Prefix: Prefix));
        }
        //POST
        protected override DriverResult Editor(CarouselSlidePart part, IUpdateModel updater, dynamic shapeHelper)
        {
            updater.TryUpdateModel(part, Prefix, null, null);
            return Editor(part, shapeHelper);
        }
    }
}
