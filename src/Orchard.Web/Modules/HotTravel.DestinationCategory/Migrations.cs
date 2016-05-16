using System.Data;
using Orchard.ContentManagement.MetaData;
using Orchard.Core.Contents.Extensions;
using Orchard.Data.Migration;
using HotTravel.DestinationCategory.Models;

namespace HotTravel.DestinationCategory
{
    public class Migrations : DataMigrationImpl {

        public int Create() {
			// Creating table DestinationCategoryPartRecord
			SchemaBuilder.CreateTable("DestinationCategoryPartRecord", table => table
				.ContentPartRecord()
				.Column("Header", DbType.String)
				.Column("Description", DbType.String, x => x.Unlimited())
				.Column("LinkedPage", DbType.String)
				.Column("Item1Title", DbType.String)
				.Column("Item1Location", DbType.String)
				.Column("Item1LinkedPage", DbType.String)
				.Column("Item2Title", DbType.String)
				.Column("Item2Location", DbType.String)
				.Column("Item2LinkedPage", DbType.String)
				.Column("Item3Title", DbType.String)
				.Column("Item3Location", DbType.String)
				.Column("Item3LinkedPage", DbType.String)
			);

            ContentDefinitionManager.AlterPartDefinition(typeof(DestinationCategoryPart).Name, cfg => cfg.Attachable().WithField("Item1Image", f => f
            .OfType("MediaLibraryPickerField")
            .WithDisplayName("Item 1 Image")));

            ContentDefinitionManager.AlterPartDefinition(typeof(DestinationCategoryPart).Name, cfg => cfg.Attachable().WithField("Item2Image", f => f
            .OfType("MediaLibraryPickerField")
            .WithDisplayName("Item 2 Image")));

            ContentDefinitionManager.AlterPartDefinition(typeof(DestinationCategoryPart).Name, cfg => cfg.Attachable().WithField("Item3Image", f => f
            .OfType("MediaLibraryPickerField")
            .WithDisplayName("Item 3 Image")));

            return 1;
        }
    }
}