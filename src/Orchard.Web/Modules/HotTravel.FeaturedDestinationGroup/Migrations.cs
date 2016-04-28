using System.Data;
using Orchard.Data.Migration;
using Orchard.ContentManagement.MetaData;
using HotTravel.FeaturedDestinationGroup.Models;
using Orchard.Core.Contents.Extensions;
using Orchard.Core.Containers.Models;

namespace HotTravel.FeaturedDestinationGroup
{
    public class Migrations : DataMigrationImpl {

        public int Create() {
			// Creating table FeaturedDestinationGroupPartRecord
			SchemaBuilder.CreateTable("FeaturedDestinationGroupPartRecord", table => table
				.ContentPartRecord()
				.Column("Title", DbType.String)
				.Column("LinkedPage", DbType.String)
			);

            ContentDefinitionManager.AlterPartDefinition(typeof(FeaturedDestinationGroupPart).Name, cfg => cfg.Attachable().WithField("ContentItems", f => f
            .OfType("ContentPickerField")
            .WithDisplayName("Content Items")));

            return 1;
        }
    }
}