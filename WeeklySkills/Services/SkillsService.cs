using WeeklySkills.Models;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Linq;

namespace WeeklySkills.Services
{
    public class SkillsService
    {
        private readonly IMongoCollection<Question> _Questions;

        public SkillsService(ISkillsDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _Questions = database.GetCollection<Question>(settings.SkillsCollectionName);
        }

        public List<Question> Get() =>
            _Questions.Find(Question => true).ToList();

        public List<Question> Get(string topic) =>
            _Questions.Find(Question => Question.topic == topic).ToList();

        public Question Create(Question Question)
        {
            _Questions.InsertOne(Question);
            return Question;
        }

        public void Update(string id, Question QuestionIn) =>
            _Questions.ReplaceOne(Question => Question.Id == id, QuestionIn);

        public void Remove(Question QuestionIn) =>
            _Questions.DeleteOne(Question => Question.Id == QuestionIn.Id);

        public void Remove(string id) => 
            _Questions.DeleteOne(Question => Question.Id == id);
    }
}