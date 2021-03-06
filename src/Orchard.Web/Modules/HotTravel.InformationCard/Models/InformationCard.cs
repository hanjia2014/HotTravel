﻿using Orchard.ContentManagement;
using Orchard.ContentManagement.Records;
using System.ComponentModel.DataAnnotations;

namespace HotTravel.InformationCard.Models
{
    public class InformationCardPartRecord : ContentPartRecord
    {
        public virtual bool IsWider { get; set; }
        public virtual string Title { get; set; }
        public virtual string Text { get; set; }
        public virtual string Location { get; set; }
        public virtual string LinkedPage { get; set; }
    }

    public class InformationCardPart : ContentPart<InformationCardPartRecord>
    {
        public bool IsWider { get { return Retrieve(p => p.IsWider); } set { Store(p => p.IsWider, value); } }
        public string Title { get { return Retrieve(p => p.Title); } set { Store(p => p.Title, value); } }
        [StringLength(5000)]
        public string Text { get { return Retrieve(p => p.Text); } set { Store(p => p.Text, value); } }
        public string Location { get { return Retrieve(p => p.Location); } set { Store(p => p.Location, value); } }
        public string LinkedPage { get { return Retrieve(p => p.LinkedPage); } set { Store(p => p.LinkedPage, value); } }
    }
}
