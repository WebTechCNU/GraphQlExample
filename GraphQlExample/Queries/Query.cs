using GraphQlExample.Models;
using GraphQlExample.Repositories;
using GraphQlExample.Repositories.Interfaces;

namespace GraphQlExample.Queries
{
    public class Query
    {
        private IRepository repository;

        public Query(IRepository repository)
        {
            this.repository = repository;
        }

        public List<Topic> GetTopics() 
        {
            return repository.GetTopics();
        }
    }
}
