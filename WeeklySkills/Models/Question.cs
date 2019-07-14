using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace WeeklySkills.Models
{
    public class Question
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("QuestionDescription")]
        public string QuestionDescription { get; set; }

        [BsonElement("questionId")]
        public string QuestionId { get; set; }

        [BsonElement("topic")]
        public string topic { get; set; }

        [BsonElement("Option1")]
        public string Option1 { get; set; }

        [BsonElement("Option2")]
        public string Option2 { get; set; }
        [BsonElement("Option3")]
         public string Option3 { get; set; }
        [BsonElement("Option4")]
         public string Option4 { get; set; }
        [BsonElement("Answer")]
         public string Answer { get; set; }
    }
}