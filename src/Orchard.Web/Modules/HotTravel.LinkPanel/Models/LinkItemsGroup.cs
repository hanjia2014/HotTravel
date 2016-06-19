using Orchard.ContentManagement;
using Orchard.ContentManagement.Records;
using System.Collections.Generic;

namespace HotTravel.LinkPanel.Models
{
    public class LinkItemsGroupPartRecord : ContentPartRecord
    {
        public virtual List<LinkItemPartRecord> LinkItems { get; set; }
    }

    public class LinkItemsGroupPart : ContentPart<LinkItemsGroupPartRecord>
    {
        public List<LinkItemPartRecord> LinkItems { get { return Retrieve(p => p.LinkItems); } set { Store(p => p.LinkItems, value); } }
    }
}
