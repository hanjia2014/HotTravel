using HotTravel.FeaturedDestinationGroup.Models;
using Orchard.ContentManagement.Handlers;
using Orchard.Data;

namespace HotTravel.FeaturedDestinationGroup.Handlers
{
    public class FeaturedDestinationHandlerGroup : ContentHandler
    {
        public FeaturedDestinationHandlerGroup(IRepository<FeaturedDestinationGroupPartRecord> repository)
        {
            Filters.Add(StorageFilter.For(repository));
        }
    }
}
