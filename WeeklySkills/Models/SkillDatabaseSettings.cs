namespace WeeklySkills.Models
{
    public class SkillsDatabaseSettings : ISkillsDatabaseSettings
    {
        public string SkillsCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }

    public interface ISkillsDatabaseSettings
    {
        string SkillsCollectionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
}