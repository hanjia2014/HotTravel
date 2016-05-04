using HotTravel.InformationCard.Models;
using Orchard.ContentManagement.Handlers;
using Orchard.Data;

namespace HotTravel.InformationCard.Handlers
{
    public class InformationCardGroupHandler : ContentHandler
    {
        public InformationCardGroupHandler(IRepository<InformationCardGroupPartRecord> repository)
        {
            Filters.Add(StorageFilter.For(repository));
        }
    }
}
