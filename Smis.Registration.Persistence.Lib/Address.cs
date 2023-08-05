using System;
using System.ComponentModel.DataAnnotations;
using MongoDB.Bson.Serialization.Attributes;

namespace Smis.Registration.Persistence.Lib
{
    [BsonDiscriminator("address")]
    public class Address
	{
        [BsonElement("addressLine1")]
        [BsonRequired]
        [Required]
        public string AddressLine1 { get; set; }

        [BsonElement("addressLine2")]
        [BsonRequired]
        [Required]
        public string AddressLine2 { get; set; }

        [BsonElement("addressLine3")]
        [BsonIgnoreIfNull]
        public string? AddressLine3 { get; set; }

        [BsonElement("addressLine4")]
        [BsonIgnoreIfNull]
        public string? AddressLine4 { get; set; }

        [BsonElement("postCode")]
        [BsonRequired]
        [Required]
        public string PostCode { get; set; }
	}
}

