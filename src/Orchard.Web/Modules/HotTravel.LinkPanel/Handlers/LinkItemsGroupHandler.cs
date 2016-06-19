using HotTravel.LinkPanel.Models;
using Orchard.ContentManagement.Handlers;
using Orchard.Data;

namespace HotTravel.LinkPanel.Handlers
{
    public class LinkItemsGroupHandler : ContentHandler
    {
        public LinkItemsGroupHandler(IRepository<LinkItemsGroupPartRecord> repository)
        {
            Filters.Add(StorageFilter.For(repository));
        }
    }
}
