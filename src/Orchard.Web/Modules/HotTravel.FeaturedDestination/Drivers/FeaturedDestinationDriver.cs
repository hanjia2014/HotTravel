using System.Runtime.CompilerServices;
using HotTravel.FeaturedDestination.Models;
using Orchard.ContentManagement.Drivers;
using Orchard.ContentManagement;
using Orchard.MediaLibrary.Fields;
using System.Linq;

namespace HotTravel.FeaturedDestination.Drivers
{
    public class FeaturedDestinationDriver : ContentPartDriver<FeaturedDestinationPart>
    {
        protected override DriverResult Display(FeaturedDestinationPart part, string displayType, dynamic shapeHelper)
        {
            var img = (MediaLibraryPickerField)part.Fields.FirstOrDefault(p => p.Name == "DestinationImage");
            var imglink = img == null ? string.Empty : img.FirstMediaUrl;

            return ContentShape("Parts_FeaturedDestination", () => shapeHelper.Parts_FeaturedDestination(
                Name: part.Name,
                Location: part.Location,
                LinkedPage: part.LinkedPage,
                ImageUrl: imglink
                ));
        }

        //GET
        protected override DriverResult Editor(FeaturedDestinationPart part, dynamic shapeHelper)
        {
            return ContentShape("Parts_FeaturedDestination_Edit", () => shapeHelper.EditorTemplate(TemplateName: "Parts/FeaturedDestination",
                    Model: part,
                    Prefix: Prefix));
        }
        //POST
        protected override DriverResult Editor(FeaturedDestinationPart part, IUpdateModel updater, dynamic shapeHelper)
        {
            updater.TryUpdateModel(part, Prefix, null, null);
            return Editor(part, shapeHelper);
        }
    }
}
