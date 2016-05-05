using HotTravel.InformationCardGroup.Models;
using Orchard.ContentManagement.Handlers;
using Orchard.Data;

namespace HotTravel.InformationCardGroup.Handlers
{
    public class InformationCardGroupHandler : ContentHandler
    {
        public InformationCardGroupHandler(IRepository<InformationCardGroupPartRecord> repository)
        {
            Filters.Add(StorageFilter.For(repository));
        }
    }
}
