using HotTravel.FeaturedDestinationGroup.Models;
using Orchard.ContentManagement.Drivers;
using System.Linq;
using Orchard.ContentPicker.Fields;
using System.Collections.Generic;
using HotTravel.FeaturedDestination.Models;

namespace HotTravel.FeaturedDestinationGroup.Drivers
{
    public class FeaturedDestinationDriver : ContentPartDriver<FeaturedDestinationGroupPart>
    {
        protected override DriverResult Display(FeaturedDestinationGroupPart part, string displayType, dynamic shapeHelper)
        {
            var itemsField = (ContentPickerField)part.Fields.FirstOrDefault(p => p.Name == "ContentItems");
            var contentItems = itemsField.ContentItems;
            var featuredDestinations = new List<FeaturedDestinationPart>();
            foreach(var contentItem in contentItems)
            {
                if(contentItem.ContentType == "FeaturedDestination")
                {
                    foreach(var itemPart in contentItem.Parts)
                    {
                        if(itemPart is FeaturedDestinationPart)
                        {
                            featuredDestinations.Add(itemPart as FeaturedDestinationPart);
                        }
                    }
                }
            }
            
            return ContentShape("Parts_FeaturedDestinationGroup", () => shapeHelper.Parts_FeaturedDestinationGroup(
                Name: part.Title,
                LinkedPage: part.LinkedPage,
                FeaturedDestinations: featuredDestinations
                ));
        }

        ////GET
        //protected override DriverResult Editor(FeaturedDestinationGroupPart part, dynamic shapeHelper)
        //{
        //    return ContentShape("Parts_FeaturedDestinationGroup_Edit", () => shapeHelper.EditorTemplate(TemplateName: "Parts/FeaturedDestinationGroup",
        //            Model: part,
        //            Prefix: Prefix));
        //}
        ////POST
        //protected override DriverResult Editor(FeaturedDestinationGroupPart part, IUpdateModel updater, dynamic shapeHelper)
        //{
        //    updater.TryUpdateModel(part, Prefix, null, null);
        //    return Editor(part, shapeHelper);
        //}
    }
}
