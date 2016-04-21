using System.Data;
using Orchard.Data.Migration;
using Orchard.ContentManagement.MetaData;
using HotTravel.HeaderImageSection.Models;
using Orchard.Core.Contents.Extensions;

namespace HotTravel.HeaderImageSection
{
    public class Migrations : DataMigrationImpl {

        public int Create() {
			// Creating table HeaderImageSectionPartRecord
			SchemaBuilder.CreateTable("HeaderImageSectionPartRecord", table => table
				.ContentPartRecord()
				.Column("Title", DbType.String)
				.Column("Description", DbType.String)
				.Column("IsSmall", DbType.Boolean)
				.Column("IsLarge", DbType.Boolean)
				.Column("IsDestinationHeader", DbType.Boolean)
                .Column("IsOverlap", DbType.Boolean)
            );

            ContentDefinitionManager.AlterPartDefinition(typeof(HeaderImageSectionPart).Name, cfg => cfg.Attachable().WithField("HeaderImage", f => f
            .OfType("MediaLibraryPickerField")
            .WithDisplayName("Header Image")));

            return 1;
        }
    }
}