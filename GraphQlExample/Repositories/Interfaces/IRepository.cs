using GraphQlExample.Models;

namespace GraphQlExample.Repositories.Interfaces
{
    public interface IRepository
    {
        void AddTopic(Topic topic);
        List<Topic> GetTopics();
    }
}
