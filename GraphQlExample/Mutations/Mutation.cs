using GraphQlExample.Models;
using GraphQlExample.Repositories.Interfaces;

namespace GraphQlExample.Mutations
{
    public class Mutation
    {
        IRepository repository;

        public Mutation(IRepository repository)
        {
            this.repository = repository;
        }

        public void AddTopic(Topic topic) 
        {
            repository.AddTopic(topic);
        }
    }
}
