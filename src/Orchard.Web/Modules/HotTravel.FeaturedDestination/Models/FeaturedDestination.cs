using Orchard.ContentManagement;
using Orchard.ContentManagement.Records;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotTravel.FeaturedDestination.Models
{
    public class FeaturedDestinationPartRecord : ContentPartRecord
    {
        public virtual string Name { get; set; }
        public virtual string Location { get; set; }
        public virtual string LinkedPage { get; set; }
    }

    public class FeaturedDestinationPart : ContentPart<FeaturedDestinationPartRecord>
    {
        [DisplayName("Destination name")]
        public string Name { get { return Retrieve(r => r.Name); } set { Store(r => r.Name, value); } }
        [DisplayName("The Location")]
        public string Location { get { return Retrieve(r => r.Location); } set { Store(r => r.Location, value); } }
        [DisplayName("What is the page it is linked to")]
        public string LinkedPage { get { return Retrieve(r => r.LinkedPage); } set { Store(r => r.LinkedPage, value); } }
    }
}
