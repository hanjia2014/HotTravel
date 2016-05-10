using HotTravel.Carousel.Models;
using Orchard.ContentManagement.Handlers;
using Orchard.Data;

namespace HotTravel.Carousel.Handlers
{
    public class CarouselHandler : ContentHandler
    {
        public CarouselHandler(IRepository<CarouselPartRecord> repository)
        {
            Filters.Add(StorageFilter.For(repository));
        }
    }
}
