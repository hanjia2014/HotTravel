using HotTravel.Carousel.Models;
using Orchard.ContentManagement.Handlers;
using Orchard.Data;

namespace HotTravel.Carousel.Handlers
{
    public class CarouselSlideHandler : ContentHandler
    {
        public CarouselSlideHandler(IRepository<CarouselSlidePartRecord> repository)
        {
            Filters.Add(StorageFilter.For(repository));
        }
    }
}
