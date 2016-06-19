using HotTravel.LinkPanel.Models;
using Orchard.ContentManagement.Handlers;
using Orchard.Data;

namespace HotTravel.LinkPanel.Handlers
{
    public class LinkItemHandler : ContentHandler
    {
        public LinkItemHandler(IRepository<LinkItemPartRecord> repository)
        {
            Filters.Add(StorageFilter.For(repository));
        }
    }
}
