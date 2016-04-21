using Orchard.ContentManagement;
using Orchard.ContentManagement.Records;
using System.ComponentModel;

namespace HotTravel.HeaderImageSection.Models
{
    public class HeaderImageSectionPartRecord : ContentPartRecord
    {
        public virtual string Title { get; set; }
        public virtual string Description { get; set; }
        public virtual bool IsSmall { get; set; }
        public virtual bool IsLarge { get; set; }
        public virtual bool IsDestinationHeader { get; set; }
        public virtual bool IsOverlap { get; set; }
    }

    public class HeaderImageSectionPart : ContentPart<HeaderImageSectionPartRecord>
    {
        public string Title { get { return Retrieve(r => r.Title); } set { Store(r => r.Title, value); } }
        public string Description { get { return Retrieve(r => r.Description); } set { Store(r => r.Description, value); } }
        [DisplayName("Is this a small size image")]
        public bool IsSmall { get { return Retrieve(r => r.IsSmall); } set { Store(r => r.IsSmall, value); } }
        [DisplayName("Is this a large size image")]
        public bool IsLarge { get { return Retrieve(r => r.IsLarge); } set { Store(r => r.IsLarge, value); } }
        [DisplayName("Is this a destination page header image")]
        public bool IsDestinationHeader { get { return Retrieve(r => r.IsDestinationHeader); } set { Store(r => r.IsDestinationHeader, value); } }
        [DisplayName("Is this image need to be overlapped?")]
        public bool IsOverlap { get { return Retrieve(r => r.IsOverlap); } set { Store(r => r.IsOverlap, value); } }
    }
}
