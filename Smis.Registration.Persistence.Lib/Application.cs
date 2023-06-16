using System;
using Mongo.Migration.Documents;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson.Serialization.IdGenerators;
using Persistence;

namespace SmisRegistrationPersistence
{
    [BsonDiscriminator(Application.TableName)]
    public class Application: IDocument
	{
        [BsonIgnore]
        public const string TableName = "application";

        [BsonElement("firstName")]
        public string FirstName { get; set; }

        [BsonElement("surname")]
        public string Surname { get; set; }

        [BsonElement("dob")]
        [BsonDateTimeOptions]
        public DateTime DateOfBirthday { get; set ; }

        [BsonElement("applicationNumber")]     
        public string ApplicationNumber { get; set; }

        [BsonElement("title")]
        public string Title { get; set; }

        [BsonElement("contactAddress")]
        public Address ContactAddress { get; set; }

        [BsonElement("primaryGuardianName")]
        public string PrimaryGuardianName { get; set; }

        [BsonElement("primaryGuardianSurname")]
        public string PrimaryGuardianSurname { get; set; }

        [BsonElement("primaryGuardianTelephone")]
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

        [BsonIgnoreIfNull]
        public DocumentVersion Version { get; set; }

        public Application(string firstName, string surname, DateTime dateOfBirthday, string applicationNumber, string title, Address contactAddress, string primaryGuardianName, string primaryGuardianSurname, string primaryGuardianTelephone)
        {
            //ID = id ?? throw new ArgumentNullException("Id is null.");
            FirstName = firstName ?? throw new ArgumentNullException("firstName is null.");
            Surname = surname ?? throw new ArgumentNullException("surname is null.");
            DateOfBirthday = dateOfBirthday;
            ApplicationNumber = applicationNumber ?? throw new ArgumentNullException("applicationNumber is null.");
            Title = title ?? throw new ArgumentNullException("title is null.");
            ContactAddress = contactAddress ?? throw new ArgumentNullException("contactAddress is null.");
            PrimaryGuardianName = primaryGuardianName ?? throw new ArgumentNullException("primaryGuardianName is null.");
            PrimaryGuardianSurname = primaryGuardianSurname ?? throw new ArgumentNullException("primaryGuardianSurname is null.");
            PrimaryGuardianTelephone = primaryGuardianTelephone ?? throw new ArgumentNullException("primaryGuardianTelephone is null.");
        }
    }
}

