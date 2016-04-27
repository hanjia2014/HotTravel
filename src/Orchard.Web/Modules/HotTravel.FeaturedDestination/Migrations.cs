using System.Data;
using Orchard.Data.Migration;
using HotTravel.FeaturedDestination.Models;
using Orchard.ContentManagement.MetaData;
using Orchard.Core.Contents.Extensions;

namespace HotTravel.FeaturedDestination
{
    public class Migrations : DataMigrationImpl {

        public int Create() {
			// Creating table FeaturedDestinationPartRecord
			SchemaBuilder.CreateTable("FeaturedDestinationPartRecord", table => table
				.ContentPartRecord()
				.Column("Name", DbType.String)
				.Column("Location", DbType.String)
                .Column("LinkedPage", DbType.String)
			);

            ContentDefinitionManager.AlterPartDefinition(typeof(FeaturedDestinationPart).Name, cfg => cfg.Attachable().WithField("DestinationImage", f => f
            .OfType("MediaLibraryPickerField")
            .WithDisplayName("Destination Image")));

            return 1;
        }
    }
}