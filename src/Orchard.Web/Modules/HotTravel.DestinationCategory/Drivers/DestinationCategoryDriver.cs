using HotTravel.DestinationCategory.Models;
using Orchard.ContentManagement;
using Orchard.ContentManagement.Drivers;
using Orchard.MediaLibrary.Fields;
using System.Linq;

namespace HotTravel.DestinationCategory.Drivers
{
    public class DestinationCategoryDriver : ContentPartDriver<DestinationCategoryPart>
    {
        protected override DriverResult Display(DestinationCategoryPart part, string displayType, dynamic shapeHelper)
        {
            var img = (MediaLibraryPickerField)part.Fields.FirstOrDefault(p => p.Name == "Item1Image");
            var img1link = img == null ? string.Empty : img.FirstMediaUrl;

            img = (MediaLibraryPickerField)part.Fields.FirstOrDefault(p => p.Name == "Item2Image");
            var img2link = img == null ? string.Empty : img.FirstMediaUrl;

            img = (MediaLibraryPickerField)part.Fields.FirstOrDefault(p => p.Name == "Item3Image");
            var img3link = img == null ? string.Empty : img.FirstMediaUrl;

            return ContentShape("Parts_DestinationCategory", () => shapeHelper.Parts_DestinationCategory(
                Header: part.Header,
                Description: part.Description,
                LinkedPage: part.LinkedPage,
                Item1Title: part.Item1Title,
                Item1Location: part.Item1Location,
                Item1LinkedPage: part.Item1LinkedPage,
                Item2Title: part.Item2Title,
                Item2Location: part.Item2Location,
                Item2LinkedPage: part.Item2LinkedPage,
                Item3Title: part.Item3Title,
                Item3Location: part.Item3Location,
                Item3LinkedPage: part.Item3LinkedPage,
                Image1Url: img1link,
                Image2Url: img2link,
                Image3Url: img3link
                ));
        }

        //GET
        protected override DriverResult Editor(DestinationCategoryPart part, dynamic shapeHelper)
        {
            return ContentShape("Parts_DestinationCategory_Edit", () => shapeHelper.EditorTemplate(TemplateName: "Parts/DestinationCategory",
                    Model: part,
                    Prefix: Prefix));
        }
        //POST
        protected override DriverResult Editor(DestinationCategoryPart part, IUpdateModel updater, dynamic shapeHelper)
        {
            updater.TryUpdateModel(part, Prefix, null, null);
            return Editor(part, shapeHelper);
        }
    }
}
