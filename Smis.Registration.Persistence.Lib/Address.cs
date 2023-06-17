using System;
using MongoDB.Bson.Serialization.Attributes;

namespace Smis.Registration.Persistence.Lib
{
    [BsonDiscriminator("address")]
    public class Address
	{
        [BsonElement("addressLine1")]
        public string AddressLine1 { get; set; }

        [BsonElement("addressLine2")]
        public string AddressLine2 { get; set; }

        [BsonElement("addressLine3")]
        public string? AddressLine3 { get; set; }

        [BsonElement("addressLine4")]
        public string? AddressLine4 { get; set; }

        [BsonElement("postCode")]
        public string PostCode { get; set; }

		public Address(
            string addressLine1,
            string addressLine2,
            string addressLine3,
            string addressLine4,
            string postCode)
		{

            AddressLine1 = addressLine1 ?? throw new ArgumentException("Address line 1 is missinng");
            AddressLine2 = addressLine2 ?? throw new ArgumentException("Address line 1 is missinng");
            AddressLine3 = addressLine3;
            AddressLine4 = addressLine4;
            PostCode = postCode ?? throw new ArgumentException("Postcode is missinng");
        }

	}
}

