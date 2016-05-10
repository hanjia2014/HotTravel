using HotTravel.Carousel.Models;
using Orchard.ContentManagement;
using Orchard.ContentManagement.Drivers;
using Orchard.ContentPicker.Fields;
using System.Collections.Generic;
using System.Linq;

namespace HotTravel.Carousel.Drivers
{
    public class CarouselDriver : ContentPartDriver<CarouselPart>
    {
        protected override DriverResult Display(CarouselPart part, string displayType, dynamic shapeHelper)
        {
            var itemsField = (ContentPickerField)part.Fields.FirstOrDefault(p => p.Name == "ContentItems");
            var contentItems = itemsField.ContentItems;
            var slides = new List<CarouselSlideViewModel>();
            foreach (var contentItem in contentItems)
            {
                if (contentItem.ContentType == "CarouselSlide")
                {
                    foreach (var itemPart in contentItem.Parts)
                    {
                        if (itemPart is CarouselSlidePart)
                        {
                            slides.Add(new CarouselSlideViewModel(itemPart as CarouselSlidePart));
                        }
                    }
                }
            }

            return ContentShape("Parts_Carousel", () => shapeHelper.Parts_Carousel( Slides: slides ));
        }

        //GET
        protected override DriverResult Editor(CarouselPart part, dynamic shapeHelper)
        {

            return ContentShape("Parts_Carousel_Edit", () => shapeHelper.EditorTemplate(TemplateName: "Parts/Carousel",
                    Model: part,
                    Prefix: Prefix));
        }
        //POST
        protected override DriverResult Editor(CarouselPart part, IUpdateModel updater, dynamic shapeHelper)
        {

            updater.TryUpdateModel(part, Prefix, null, null);
            return Editor(part, shapeHelper);
        }
    }
}
