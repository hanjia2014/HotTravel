using Orchard.ContentManagement;
using Orchard.ContentManagement.Records;
using System.ComponentModel.DataAnnotations;

namespace HotTravel.LinkPanel.Models
{
    public class LinkItemPartRecord : ContentPartRecord
    {
        public virtual string Caption { get; set; }
        public virtual string LinkedPage { get; set; }
        public virtual string BodyText { get; set; }
    }

    public class LinkItemPart : ContentPart<LinkItemPartRecord>
    {
        public string Caption { get { return Retrieve(p => p.Caption); } set { Store(p => p.Caption, value); } }
        public string LinkedPage { get { return Retrieve(p => p.LinkedPage); } set { Store(p => p.LinkedPage, value); } }
        [StringLength(5000)]
        public string BodyText { get { return Retrieve(p => p.BodyText); } set { Store(p => p.BodyText, value); } }
    }
}
