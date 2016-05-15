using HotTravel.DestinationCategory.Models;
using Orchard.ContentManagement.Handlers;
using Orchard.Data;

namespace HotTravel.DestinationCategory.Handlers
{
    public class DestinationCategoryHandler : ContentHandler
    {
        public DestinationCategoryHandler(IRepository<DestinationCategoryPartRecord> repository)
        {
            Filters.Add(StorageFilter.For(repository));
        }
    }
}
