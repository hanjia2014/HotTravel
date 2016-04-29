using HotTravel.FeaturedDestinationGroup.Models;
using Orchard.ContentManagement.Drivers;
using System.Linq;
using Orchard.ContentPicker.Fields;
using System.Collections.Generic;
using HotTravel.FeaturedDestination.Models;
using Orchard.ContentManagement;


namespace HotTravel.FeaturedDestinationGroup.Drivers
{
    public class FeaturedDestinationDriver : ContentPartDriver<FeaturedDestinationGroupPart>
    {
        private IContentManager _contentManager;
        public FeaturedDestinationDriver(IContentManager contentManager)
        {
            _contentManager = contentManager;
        }
        protected override DriverResult Display(FeaturedDestinationGroupPart part, string displayType, dynamic shapeHelper)
        {
            var itemsField = (ContentPickerField)part.Fields.FirstOrDefault(p => p.Name == "ContentItems");
            var contentItems = itemsField.ContentItems;
            var featuredDestinations = new List<FeaturedDestinationViewModel>();
            foreach(var contentItem in contentItems)
            {
                if(contentItem.ContentType == "FeaturedDestination")
                {
                    foreach(var itemPart in contentItem.Parts)
                    {
                        if(itemPart is FeaturedDestinationPart)
                        {
                            featuredDestinations.Add(new FeaturedDestinationViewModel(itemPart as FeaturedDestinationPart));
                        }
                    }
                }
            }

            //var destinations = _contentManager.Query<FeaturedDestinationPart, FeaturedDestinationPartRecord>().List();
            //featuredDestinations = new List<FeaturedDestinationViewModel>();
            //destinations.ToList().ForEach(p => featuredDestinations.Add(new FeaturedDestinationViewModel(p)));
            
            return ContentShape("Parts_FeaturedDestinationGroup", () => shapeHelper.Parts_FeaturedDestinationGroup(
                Title: part.Title,
                LinkedPage: part.LinkedPage,
                FeaturedDestinations: featuredDestinations
                ));
        }

        //GET
        protected override DriverResult Editor(FeaturedDestinationGroupPart part, dynamic shapeHelper)
        {
            return ContentShape("Parts_FeaturedDestinationGroup_Edit", () => shapeHelper.EditorTemplate(TemplateName: "Parts/FeaturedDestinationGroup",
                    Model: part,
                    Prefix: Prefix));
        }
        //POST
        protected override DriverResult Editor(FeaturedDestinationGroupPart part, IUpdateModel updater, dynamic shapeHelper)
        {
            updater.TryUpdateModel(part, Prefix, null, null);
            return Editor(part, shapeHelper);
        }
    }
}
