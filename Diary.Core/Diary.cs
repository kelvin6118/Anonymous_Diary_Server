using MongoDB.Bson.Serialization.Attributes;

namespace Diary.Core
{
    public class Diary
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string Id {get; set;}
        public string title { get; set; }
        public string giphy { get; set; }
        public string description { get; set; }
        public Comment[] comments { get; set; }
        public Emoji emoji { get; set; }
    }
}
