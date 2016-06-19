using HotTravel.LinkPanel.Models;
using Orchard.ContentManagement.Drivers;
using Orchard.ContentManagement;

namespace HotTravel.LinkPanel.Drivers
{
    public class LinkItemsGroupDriver : ContentPartDriver<LinkItemsGroupPart>
    {
        protected override DriverResult Display(LinkItemsGroupPart part, string displayType, dynamic shapeHelper)
        {
            return ContentShape("Parts_LinkItemsGroup", () => shapeHelper.Parts_LinkItemsGroup(
                LinkItems: part.LinkItems
                ));
        }

        //GET
        protected override DriverResult Editor(LinkItemsGroupPart part, dynamic shapeHelper)
        {
            return ContentShape("Parts_LinkItemsGroup_Edit", () => shapeHelper.EditorTemplate(TemplateName: "Parts/LinkItemsGroup",
                    Model: part,
                    Prefix: Prefix));
        }
        //POST
        protected override DriverResult Editor(LinkItemsGroupPart part, IUpdateModel updater, dynamic shapeHelper)
        {
            updater.TryUpdateModel(part, Prefix, null, null);
            return Editor(part, shapeHelper);
        }
    }
}
