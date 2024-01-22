using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace DotnetL.Model
{
    public class Book
    {
        
        public BsonDocument title { get; set; } = new BsonDocument();
        public BsonDocument author { get; set; } = new BsonDocument();
        public BsonDocument publishedYear { get; set; } = new BsonDocument();

    }
}

