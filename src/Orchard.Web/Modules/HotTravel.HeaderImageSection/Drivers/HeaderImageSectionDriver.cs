using System.Runtime.CompilerServices;
using HotTravel.HeaderImageSection.Models;
using Orchard.ContentManagement.Drivers;
using Orchard.ContentManagement;
using Orchard.MediaLibrary.Fields;
using System.Linq;

namespace HotTravel.HeaderImageSection.Drivers
{
    public class HeaderImageSectionDriver : ContentPartDriver<HeaderImageSectionPart>
    {
        protected override DriverResult Display(HeaderImageSectionPart part, string displayType, dynamic shapeHelper)
        {
            var img = (MediaLibraryPickerField)part.Fields.FirstOrDefault(p => p.Name == "HeaderImage");
            var imglink = img == null ? string.Empty : img.FirstMediaUrl;

            return ContentShape("Parts_HeaderImageSection", () => shapeHelper.Parts_HeaderImageSection(
                IsSmall: part.IsSmall,
                IsLarge: part.IsLarge,
                IsDestinationHeader: part.IsDestinationHeader,
                IsOverlap: part.IsOverlap,
                Title: part.Title,
                Description: part.Description,
                HeaderImageUrl: imglink 
                ));
        }

        //GET
        protected override DriverResult Editor(HeaderImageSectionPart part, dynamic shapeHelper)
        {

            return ContentShape("Parts_HeaderImageSection_Edit", () => shapeHelper.EditorTemplate(TemplateName: "Parts/HeaderImageSection",
                    Model: part,
                    Prefix: Prefix));
        }
        //POST
        protected override DriverResult Editor(HeaderImageSectionPart part, IUpdateModel updater, dynamic shapeHelper)
        {

            updater.TryUpdateModel(part, Prefix, null, null);
            return Editor(part, shapeHelper);
        }
    }
}
