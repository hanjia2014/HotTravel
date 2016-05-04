using HotTravel.InformationCard.Models;
using Orchard.ContentManagement.Handlers;
using Orchard.Data;

namespace HotTravel.InformationCard.Handlers
{
    public class InformationCardHandler : ContentHandler
    {
        public InformationCardHandler(IRepository<InformationCardPartRecord> repository)
        {
            Filters.Add(StorageFilter.For(repository));
        }
    }
}