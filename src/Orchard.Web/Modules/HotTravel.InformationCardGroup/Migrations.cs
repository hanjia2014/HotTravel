using System.Data;
using Orchard.ContentManagement.MetaData;
using Orchard.Core.Contents.Extensions;
using Orchard.Data.Migration;
using HotTravel.InformationCardGroup.Models;
using HotTravel.InformationCard.Models;

namespace HotTravel.InformationCardGroup
{
    public class Migrations : DataMigrationImpl {

        public int Create()
        {
			// Creating table InformationCardGroupPartRecord
			SchemaBuilder.CreateTable("InformationCardGroupPartRecord", table => table
				.ContentPartRecord()
				.Column("HeaderVisible", DbType.Boolean)
				.Column("Title", DbType.String)
				.Column("LinkedPage", DbType.String)
			);
            ContentDefinitionManager.AlterPartDefinition(typeof(InformationCardGroupPart).Name, cfg => cfg.Attachable().WithField("ContentItems", f => f
            .OfType("ContentPickerField").WithSetting("ContentPickerFieldSettings.Multiple", "True")
            .WithDisplayName("Content Items")));

            return 1;
        }

        public int UpdateFrom1()
        {
            ContentDefinitionManager.AlterPartDefinition(typeof(InformationCardGroupPart).Name, cfg => cfg.Attachable().WithField("ContentItems", f => f
            .OfType("ContentPickerField").WithSetting("ContentPickerFieldSettings.DisplayedContentTypes", typeof(InformationCardPart).Name)));
            return 2;
        }

    }
}