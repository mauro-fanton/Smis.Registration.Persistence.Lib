using System;
using MongoDB.Bson;
using MongoDB.Bson.IO;

namespace SmisRegistrationPersistenceTests.serialisation
{
	public class PartialBsonReader: IBsonReader
	{
		public PartialBsonReader()
		{
		}

        public BsonType CurrentBsonType => throw new NotImplementedException();

        public BsonReaderState State => throw new NotImplementedException();

        public void Close()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public BsonReaderBookmark GetBookmark()
        {
            throw new NotImplementedException();
        }

        public BsonType GetCurrentBsonType()
        {
            throw new NotImplementedException();
        }

        public bool IsAtEndOfFile()
        {
            throw new NotImplementedException();
        }

        public void PopSettings()
        {
            throw new NotImplementedException();
        }

        public void PushSettings(Action<BsonReaderSettings> configurator)
        {
            throw new NotImplementedException();
        }

        public BsonBinaryData ReadBinaryData()
        {
            throw new NotImplementedException();
        }

        public bool ReadBoolean()
        {
            throw new NotImplementedException();
        }

        public BsonType ReadBsonType()
        {
            throw new NotImplementedException();
        }

        public byte[] ReadBytes()
        {
            throw new NotImplementedException();
        }

        public long ReadDateTime()
        {
            throw new NotImplementedException();
        }

        public Decimal128 ReadDecimal128()
        {
            throw new NotImplementedException();
        }

        public double ReadDouble()
        {
            throw new NotImplementedException();
        }

        public void ReadEndArray()
        {
            throw new NotImplementedException();
        }

        public void ReadEndDocument()
        {
            throw new NotImplementedException();
        }

        public int ReadInt32()
        {
            throw new NotImplementedException();
        }

        public long ReadInt64()
        {
            throw new NotImplementedException();
        }

        public string ReadJavaScript()
        {
            throw new NotImplementedException();
        }

        public string ReadJavaScriptWithScope()
        {
            throw new NotImplementedException();
        }

        public void ReadMaxKey()
        {
            throw new NotImplementedException();
        }

        public void ReadMinKey()
        {
            throw new NotImplementedException();
        }

        public string ReadName(INameDecoder nameDecoder)
        {
            throw new NotImplementedException();
        }

        public void ReadNull()
        {
            throw new NotImplementedException();
        }

        public ObjectId ReadObjectId()
        {
            throw new NotImplementedException();
        }

        public IByteBuffer ReadRawBsonArray()
        {
            throw new NotImplementedException();
        }

        public IByteBuffer ReadRawBsonDocument()
        {
            throw new NotImplementedException();
        }

        public BsonRegularExpression ReadRegularExpression()
        {
            throw new NotImplementedException();
        }

        public void ReadStartArray()
        {
            throw new NotImplementedException();
        }

        public void ReadStartDocument()
        {
            throw new NotImplementedException();
        }

        public string ReadString()
        {
            throw new NotImplementedException();
        }

        public string ReadSymbol()
        {
            throw new NotImplementedException();
        }

        public long ReadTimestamp()
        {
            throw new NotImplementedException();
        }

        public void ReadUndefined()
        {
            throw new NotImplementedException();
        }

        public void ReturnToBookmark(BsonReaderBookmark bookmark)
        {
            throw new NotImplementedException();
        }

        public void SkipName()
        {
            throw new NotImplementedException();
        }

        public void SkipValue()
        {
            throw new NotImplementedException();
        }
    }
}

