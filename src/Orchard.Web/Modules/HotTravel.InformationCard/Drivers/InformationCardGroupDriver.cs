using HotTravel.InformationCard.Models;
using Orchard.ContentManagement;
using Orchard.ContentManagement.Drivers;
using Orchard.ContentPicker.Fields;
using System.Collections.Generic;
using System.Linq;

namespace HotTravel.InformationCard.Drivers
{
    public class InformationCardGroupDriver : ContentPartDriver<InformationCardGroupPart>
    {
        protected override DriverResult Display(InformationCardGroupPart part, string displayType, dynamic shapeHelper)
        {
            var itemsField = (ContentPickerField)part.Fields.FirstOrDefault(p => p.Name == "ContentItems");
            var contentItems = itemsField.ContentItems;
            var cards = new List<InformationCardPart>();
            foreach (var contentItem in contentItems)
            {
                if (contentItem.ContentType == "InformationCard")
                {
                    foreach (var itemPart in contentItem.Parts)
                    {
                        if (itemPart is InformationCardPart)
                        {
                            cards.Add(itemPart as InformationCardPart);
                        }
                    }
                }
            }

            return ContentShape("Parts_InformationCardGroup", () => shapeHelper.Parts_InformationCardGroup(
                Title: part.Title,
                LinkedPage: part.LinkedPage,
                HeaderVisible: part.HeaderVisible,
                Cards: cards
                ));
        }

        //GET
        protected override DriverResult Editor(InformationCardGroupPart part, dynamic shapeHelper)
        {

            return ContentShape("Parts_InformationCardGroup_Edit", () => shapeHelper.EditorTemplate(TemplateName: "Parts/InformationCardGroup",
                    Model: part,
                    Prefix: Prefix));
        }
        //POST
        protected override DriverResult Editor(InformationCardGroupPart part, IUpdateModel updater, dynamic shapeHelper)
        {

            updater.TryUpdateModel(part, Prefix, null, null);
            return Editor(part, shapeHelper);
        }
    }
}
