using Mongo.Migration.Documents;
using MongoDB.Bson.Serialization.Attributes;


namespace Smis.Registration.Persistence.Lib
{
    [BsonDiscriminator(Application.TableName)]
    public class Application
	{
        [BsonIgnore]
        public const string TableName = "application";

        public Guid Id { get; set; }

        [BsonElement("firstName")]
        [BsonRequired]
        public string FirstName { get; set; }

        [BsonElement("surname")]
        [BsonRequired]
        public string Surname { get; set; }

        [BsonElement("dob")]
        [BsonDateTimeOptions]
        [BsonRequired]
        public DateTime DateOfBirthday { get; set ; }

        [BsonElement("applicationNumber")]
        [BsonRequired]
        public string ApplicationNumber { get; set; }

        [BsonElement("title")]
        [BsonRequired]
        public string Title { get; set; }

        [BsonElement("contactAddress")]
        [BsonRequired]
        public Address ContactAddress { get; set; }

        [BsonElement("primaryGuardianName")]
        [BsonRequired]
        public string PrimaryGuardianName { get; set; }

        [BsonElement("primaryGuardianSurname")]
        [BsonRequired]
        public string PrimaryGuardianSurname { get; set; }

        [BsonElement("primaryGuardianTelephone")]
        [BsonRequired]
        public string PrimaryGuardianTelephone { get; set; }

        [BsonElement("secondaryGuardianName")]
        [BsonIgnoreIfNull]
        public string? SecondaryGuardianName { get; set; }

        [BsonElement("secondaryGuardianSurname")]
        [BsonIgnoreIfNull]
        public string? SecondaryGuardianSurname { get; set; }

        [BsonElement("secondaryGuardianTelephone")]
        [BsonIgnoreIfNull]
        public string? SecondaryGuardianTelephone { get; set; }       
    }
}

