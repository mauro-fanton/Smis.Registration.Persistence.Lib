using System;
using MongoDB.Bson.Serialization.Attributes;
using SmisRegistrationPersistence.serialisation;

namespace SmisRegistrationPersistenceTests.Support
{
   
    public class PocoTest
	{
        [BsonElement("dob")]
        //[BsonSerializer(typeof(DateTimeSerialiser))]
        public DateTime Dob { get; set; }

        [BsonElement("name")]
        public string Name { get; set; }

        public PocoTest()
        {

        }

	}
}

