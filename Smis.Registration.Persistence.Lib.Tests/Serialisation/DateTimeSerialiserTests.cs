using System;
using MongoDB.Bson;
using MongoDB.Bson.IO;
using MongoDB.Bson.Serialization;
using Moq;
using SmisRegistrationPersistence.serialisation;
using SmisRegistrationPersistenceTests.Support;

namespace SmisRegistrationPersistenceTests.serialisation
{
	public class DateTimeSerialiserTests
	{

        DateTimeSerialiser serialiser;
		Mock<IBsonReader> reader;
        BsonDeserializationContext context;
        BsonDeserializationArgs args = new BsonDeserializationArgs();

        public DateTimeSerialiserTests()
		{
            //serialiser = new DateTimeSerialiser();
            //reader = new Mock<IBsonReader>();
            //context = BsonDeserializationContext.CreateRoot(reader.Object);
        }

        [Fact]
		public void Deserialize_shouldDeserializeAnObject()
		{
            var actual = BsonSerializer.Deserialize<List<PocoTest>>(@"[{""dob"":""2012-05-15"",""name"":""Mauro""}, {""dob"":""2010-05-15"",""name"":""Gino""}]");
			//reader.Setup(r => r.ReadString()).Returns("2020-05-13");
            var expected = new PocoTest()
            {
                Dob = new DateTime(2012, 05, 15),
                Name = "Mauro"
            };

            //Assert.Equal(new DateTime(2020, 05, 13), serialiser.Deserialize(context, args));
            Assert.Equal(expected.Dob, actual[0].Dob);
            Assert.Equal(expected.Name, actual[0].Name);

        }

		[Fact]
		public void Serialize_shouldSerializeAnObject()
		{
			var document = new BsonDocument();
			var writer = new BsonDocumentWriter(document);			

			var pocoWithCustumDateTimeSerializer = new PocoTest()
            {
                Dob = new DateTime(2012, 05, 15),
                Name = "Mauro"
            };
            BsonSerializer.Serialize(writer, pocoWithCustumDateTimeSerializer);
 

            Assert.Equal(DateTime.Parse("2012-05-15"), document.GetElement(0).Value);
            Assert.Equal("Mauro", document.GetElement(1).Value);
        }
	}
}

