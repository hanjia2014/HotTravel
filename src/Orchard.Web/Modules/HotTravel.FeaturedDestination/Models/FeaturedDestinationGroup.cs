using Orchard.ContentManagement;
using Orchard.ContentManagement.Records;
using System.ComponentModel;

namespace HotTravel.FeaturedDestinationGroup.Models
{
    public class FeaturedDestinationGroupPartRecord : ContentPartRecord
    {
        public virtual string Title { get; set; }
        public virtual string LinkedPage { get; set; }
    }

    public class FeaturedDestinationGroupPart : ContentPart<FeaturedDestinationGroupPartRecord>
    {
        [DisplayName("The title displayed on top")]
        public string Title { get { return Retrieve(r => r.Title); } set { Store(r => r.Title, value); } }
        [DisplayName("The page that displays all destinations")]
        public string LinkedPage { get { return Retrieve(r => r.LinkedPage); } set { Store(r => r.LinkedPage, value); } }
    }
}
