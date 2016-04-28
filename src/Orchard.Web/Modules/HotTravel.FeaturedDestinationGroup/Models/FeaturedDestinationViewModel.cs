using HotTravel.FeaturedDestination.Models;
using Orchard.MediaLibrary.Fields;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotTravel.FeaturedDestinationGroup.Models
{
    public class FeaturedDestinationViewModel
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public string LinkedPage { get; set; }
        public string ImgUrl { get; set; }

        public FeaturedDestinationViewModel() { }
        public FeaturedDestinationViewModel(FeaturedDestinationPart part) {
            Name = part.Name;
            Location = part.Location;
            LinkedPage = part.LinkedPage;
            var img = (MediaLibraryPickerField)part.Fields.FirstOrDefault(p => p.Name == "DestinationImage");
            ImgUrl = img == null ? string.Empty : img.FirstMediaUrl;
        }
    }
}
