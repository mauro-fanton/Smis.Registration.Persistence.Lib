using System.ComponentModel.DataAnnotations;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;


namespace Smis.Registration.Persistence.Lib
{
    /// <summary>
    /// Rapresentation class for the Application
    /// </summary>
    [BsonDiscriminator(Application.TableName)]
    public class Application
	{

        public Application()
        {
            LastUpdated = DateTime.UtcNow;
        }

        [BsonIgnore]
        public const string TableName = "application";

        /// <summary>
        /// The unique record id
        /// </summary>
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        /// <summary>
        /// First name
        /// </summary>
        [BsonElement("firstName")]
        [BsonRequired]
        [Required]
        public string FirstName { get; set; }

        /// <summary>
        /// Surname
        /// </summary>
        [BsonElement("surname")]
        [BsonRequired]
        [Required]
        public string Surname { get; set; }

        /// <summary>
        /// Date of birth
        /// </summary>
        [BsonElement("dob")]
        [BsonDateTimeOptions]
        [BsonRequired]
        [Required]
        public DateTime DateOfBirthday { get; set ; }

        /// <summary>
        /// Unique application number
        /// </summary>
        [BsonElement("applicationNumber")]
        [BsonRequired]
        [Required]
        public string ApplicationNumber { get; set; }

        /// <summary>
        /// Title
        /// </summary>
        [BsonElement("title")]
        [BsonRequired]
        [Required]
        public string Title { get; set; }

        /// <summary>
        /// Contact address
        /// </summary>
        [BsonElement("contactAddress")]
        [BsonRequired]
        [Required]
        public Address ContactAddress { get; set; }

        /// <summary>
        /// Primary guardian name
        /// </summary>
        [BsonElement("primaryGuardianName")]
        [BsonRequired]
        [Required]
        public string PrimaryGuardianName { get; set; }

        /// <summary>
        /// Primary guardian surname
        /// </summary>
        [BsonElement("primaryGuardianSurname")]
        [BsonRequired]
        [Required]
        public string PrimaryGuardianSurname { get; set; }

        /// <summary>
        /// Primary guardian telephone number
        /// </summary>
        [BsonElement("primaryGuardianTelephone")]
        [BsonRequired]
        [Required]
        public string PrimaryGuardianTelephone { get; set; }

        /// <summary>
        /// Secondaru guardian name
        /// </summary>
        [BsonElement("secondaryGuardianName")]
        [BsonIgnoreIfNull]
        public string? SecondaryGuardianName { get; set; }

        /// <summary>
        /// Secondary guardian surname
        /// </summary>
        [BsonElement("secondaryGuardianSurname")]
        [BsonIgnoreIfNull]
        public string? SecondaryGuardianSurname { get; set; }

        /// <summary>
        /// Secondary guardian telephone number
        /// </summary>
        [BsonElement("secondaryGuardianTelephone")]
        [BsonIgnoreIfNull]
        public string? SecondaryGuardianTelephone { get; set; }

        [BsonElement("lastUpdated")]
        public DateTime LastUpdated { get; set; }
    }
}

