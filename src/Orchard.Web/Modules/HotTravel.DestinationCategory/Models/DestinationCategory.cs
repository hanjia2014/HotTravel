using Orchard.ContentManagement;
using Orchard.ContentManagement.Records;
using System.ComponentModel.DataAnnotations;

namespace HotTravel.DestinationCategory.Models
{
    public class DestinationCategoryPartRecord : ContentPartRecord
    {
        public virtual string Header { get; set; }
        public virtual string Description { get; set; }
        public virtual string LinkedPage { get; set; }

        public virtual string Item1Title { get; set; }
        public virtual string Item1Location { get; set; }
        public virtual string Item1LinkedPage { get; set; }

        public virtual string Item2Title { get; set; }
        public virtual string Item2Location { get; set; }
        public virtual string Item2LinkedPage { get; set; }

        public virtual string Item3Title { get; set; }
        public virtual string Item3Location { get; set; }
        public virtual string Item3LinkedPage { get; set; }
    }

    public class DestinationCategoryPart : ContentPart<DestinationCategoryPartRecord>
    {
        public string Header { get { return Retrieve(p => p.Header); } set { Store(p => p.Header, value); } }
        [StringLength(5000)]
        public string Description { get { return Retrieve(p => p.Description); } set { Store(p => p.Description, value); } }
        public string LinkedPage { get { return Retrieve(p => p.LinkedPage); } set { Store(p => p.LinkedPage, value); } }

        public string Item1Title { get { return Retrieve(p => p.Item1Title); } set { Store(p => p.Item1Title, value); } }
        public string Item1Location { get { return Retrieve(p => p.Item1Location); } set { Store(p => p.Item1Location, value); } }
        public string Item1LinkedPage { get { return Retrieve(p => p.Item1LinkedPage); } set { Store(p => p.Item1LinkedPage, value); } }

        public string Item2Title { get { return Retrieve(p => p.Item2Title); } set { Store(p => p.Item2Title, value); } }
        public string Item2Location { get { return Retrieve(p => p.Item2Location); } set { Store(p => p.Item2Location, value); } }
        public string Item2LinkedPage { get { return Retrieve(p => p.Item2LinkedPage); } set { Store(p => p.Item2LinkedPage, value); } }

        public string Item3Title { get { return Retrieve(p => p.Item3Title); } set { Store(p => p.Item3Title, value); } }
        public string Item3Location { get { return Retrieve(p => p.Item3Location); } set { Store(p => p.Item3Location, value); } }
        public string Item3LinkedPage { get { return Retrieve(p => p.Item3LinkedPage); } set { Store(p => p.Item3LinkedPage, value); } }
    }
}
