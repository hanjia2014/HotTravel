using System.Data;
using Orchard.Data.Migration;
using Orchard.ContentManagement.MetaData;
using HotTravel.FeaturedDestinationGroup.Models;
using Orchard.Core.Contents.Extensions;
using HotTravel.FeaturedDestination.Models;

namespace HotTravel.FeaturedDestinationGroup
{
    public class Migrations : DataMigrationImpl {

        public int Create()
        {
			// Creating table FeaturedDestinationGroupPartRecord
			SchemaBuilder.CreateTable("FeaturedDestinationGroupPartRecord", table => table
				.ContentPartRecord()
				.Column("Title", DbType.String)
				.Column("LinkedPage", DbType.String)
			);

            ContentDefinitionManager.AlterPartDefinition(typeof(FeaturedDestinationGroupPart).Name, cfg => cfg.Attachable().WithField("ContentItems", f => f
            .OfType("ContentPickerField").WithSetting("ContentPickerFieldSettings.Multiple", "True")
            .WithDisplayName("Content Items")));

            return 1;
        }

        public int UpdateFrom1()
        {
            ContentDefinitionManager.AlterPartDefinition(typeof(FeaturedDestinationGroupPart).Name, cfg => cfg.Attachable().WithField("ContentItems", f => f
            .OfType("ContentPickerField").WithSetting("ContentPickerFieldSettings.DisplayedContentTypes", typeof(FeaturedDestinationPart).Name)));
            return 2;
        }
    }
}