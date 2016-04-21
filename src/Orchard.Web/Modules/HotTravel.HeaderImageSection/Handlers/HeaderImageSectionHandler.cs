using HotTravel.HeaderImageSection.Models;
using Orchard.ContentManagement.Handlers;
using Orchard.Data;

namespace HotTravel.HeaderImageSection.Handlers
{
    public class HeaderImageSectionHandler : ContentHandler
    {
        public HeaderImageSectionHandler(IRepository<HeaderImageSectionPartRecord> repository)
        {
            Filters.Add(StorageFilter.For(repository));
        }
    }
}
