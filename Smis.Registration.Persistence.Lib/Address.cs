using System.ComponentModel.DataAnnotations;
using MongoDB.Bson.Serialization.Attributes;

namespace Smis.Registration.Persistence.Lib
{
    /// <summary>
    /// Rapresentation class for address
    /// </summary>
    [BsonDiscriminator("address")]
    public class Address
	{
        /// <summar>
        /// 1st line of address
        /// </summary>
        [BsonElement("addressLine1")]
        [BsonRequired]
        [Required]
        public string AddressLine1 { get; set; }

        /// <summary>
        /// 2nd line of address
        /// </summary>
        [BsonElement("addressLine2")]
        [BsonRequired]
        [Required]
        public string AddressLine2 { get; set; }

        /// <summary>
        /// 3rd line of address
        /// </summary>
        [BsonElement("addressLine3")]
        [BsonIgnoreIfNull]
        public string? AddressLine3 { get; set; }

        /// <summary>
        /// 4th line of address
        /// </summary>
        [BsonElement("addressLine4")]
        [BsonIgnoreIfNull]
        public string? AddressLine4 { get; set; }

        /// <summary>
        /// Post code
        /// </summary>
        [BsonElement("postCode")]
        [BsonRequired]
        [Required]
        public string PostCode { get; set; }
	}
}

