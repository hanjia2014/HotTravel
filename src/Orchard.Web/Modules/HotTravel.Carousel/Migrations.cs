using System.Data;
using Orchard.Data.Migration;
using Orchard.ContentManagement.MetaData;
using Orchard.Core.Contents.Extensions;
using HotTravel.Carousel.Models;

namespace HotTravel.Carousel
{
    public class Migrations : DataMigrationImpl {

        public int Create() {
			// Creating table CarouselPartRecord
			SchemaBuilder.CreateTable("CarouselPartRecord", table => table
				.ContentPartRecord()
			);
            ContentDefinitionManager.AlterPartDefinition(typeof(CarouselSlidePart).Name, cfg => cfg.Attachable().WithField("SlideImage", f => f
            .OfType("MediaLibraryPickerField")
            .WithDisplayName("Slide Image")));

            // Creating table CarouselSlidePartRecord
            SchemaBuilder.CreateTable("CarouselSlidePartRecord", table => table
				.ContentPartRecord()
				.Column("Title", DbType.String)
				.Column("BodyText", DbType.String, x => x.Unlimited())
				.Column("LinkedPage", DbType.String)
			);

            ContentDefinitionManager.AlterPartDefinition(typeof(CarouselPart).Name, cfg => cfg.Attachable().WithField("ContentItems", f => f
            .OfType("ContentPickerField")
            .WithSetting("ContentPickerFieldSettings.Multiple", "True")
            .WithSetting("ContentPickerFieldSettings.DisplayedContentTypes", typeof(CarouselSlidePart).Name)
            .WithDisplayName("Content Items")));

            return 1;
        }
    }
}