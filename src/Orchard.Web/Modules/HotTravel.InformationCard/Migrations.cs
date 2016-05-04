using System;
using System.Collections.Generic;
using System.Data;
using Orchard.ContentManagement.Drivers;
using Orchard.ContentManagement.MetaData;
using Orchard.ContentManagement.MetaData.Builders;
using Orchard.Core.Contents.Extensions;
using Orchard.Data.Migration;
using HotTravel.InformationCard.Models;

namespace HotTravel.InformationCard {
    public class Migrations : DataMigrationImpl {

        public int Create() {
			// Creating table InformationCardPartRecord
			SchemaBuilder.CreateTable("InformationCardPartRecord", table => table
				.ContentPartRecord()
				.Column("IsWider", DbType.Boolean)
				.Column("Title", DbType.String)
				.Column("Text", DbType.String)
				.Column("Location", DbType.String)
				.Column("LinkedPage", DbType.String)
			);

            ContentDefinitionManager.AlterPartDefinition(typeof(InformationCardPart).Name, cfg => cfg.Attachable());

            return 1;
        }
    }
}