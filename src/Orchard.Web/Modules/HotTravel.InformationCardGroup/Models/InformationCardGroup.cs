using Orchard.ContentManagement;
using Orchard.ContentManagement.Records;

namespace HotTravel.InformationCardGroup.Models
{
    public class InformationCardGroupPartRecord : ContentPartRecord
    {
        public virtual bool HeaderVisible { get; set; }
        public virtual string Title { get; set; }
        public virtual string LinkedPage { get; set; }
    }

    public class InformationCardGroupPart : ContentPart<InformationCardGroupPartRecord>
    {
        public bool HeaderVisible { get { return Retrieve(p => p.HeaderVisible); } set { Store(p => p.HeaderVisible, value); } }
        public string Title { get { return Retrieve(p => p.Title); } set { Store(p => p.Title, value); } }
        public string LinkedPage { get { return Retrieve(p => p.LinkedPage); } set { Store(p => p.LinkedPage, value); } }
    }
}
