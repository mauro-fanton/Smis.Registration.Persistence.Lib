using System;
using MongoDB.Bson.Serialization.Attributes;

namespace Smis.Registration.Persistence.Lib
{
    [BsonDiscriminator("address")]
    public class Address
	{
        [BsonElement("addressLine1")]
        [BsonRequired]
        public string AddressLine1 { get; set; }

        [BsonElement("addressLine2")]
        [BsonRequired]
        public string AddressLine2 { get; set; }

        [BsonElement("addressLine3")]
        public string? AddressLine3 { get; set; }

        [BsonElement("addressLine4")]
        public string? AddressLine4 { get; set; }

        [BsonElement("postCode")]
        [BsonRequired]
        public string PostCode { get; set; }
	}
}

