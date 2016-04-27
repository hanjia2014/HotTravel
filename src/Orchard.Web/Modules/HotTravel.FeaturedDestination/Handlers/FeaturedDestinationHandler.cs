using HotTravel.FeaturedDestination.Models;
using Orchard.ContentManagement.Handlers;
using Orchard.Data;

namespace HotTravel.FeaturedDestination.Handlers
{
    public class FeaturedDestinationHandler : ContentHandler
    {
        public FeaturedDestinationHandler(IRepository<FeaturedDestinationPartRecord> repository)
        {
            Filters.Add(StorageFilter.For(repository));
        }
    }
}
