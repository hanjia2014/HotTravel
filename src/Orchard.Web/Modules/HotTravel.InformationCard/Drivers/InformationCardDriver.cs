using HotTravel.InformationCard.Models;
using Orchard.ContentManagement;
using Orchard.ContentManagement.Drivers;

namespace HotTravel.InformationCard.Drivers
{
    public class InformationCardDriver : ContentPartDriver<InformationCardPart>
    {
        protected override DriverResult Display(InformationCardPart part, string displayType, dynamic shapeHelper)
        {
            return ContentShape("Parts_InformationCard", () => shapeHelper.Parts_InformationCard(
                IsWider: part.IsWider,
                Title: part.Title,
                Text: part.Text,
                Location: part.Location,
                LinkedPage: part.LinkedPage
                ));
        }

        //GET
        protected override DriverResult Editor(InformationCardPart part, dynamic shapeHelper)
        {

            return ContentShape("Parts_InformationCard_Edit", () => shapeHelper.EditorTemplate(TemplateName: "Parts/InformationCard",
                    Model: part,
                    Prefix: Prefix));
        }
        //POST
        protected override DriverResult Editor(InformationCardPart part, IUpdateModel updater, dynamic shapeHelper)
        {

            updater.TryUpdateModel(part, Prefix, null, null);
            return Editor(part, shapeHelper);
        }
    }
}
