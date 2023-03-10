using GraphQlExample.Models;
using GraphQlExample.Repositories.Interfaces;

namespace GraphQlExample.Repositories
{
    public class Repository: IRepository
    {
        List<Topic> datasource = new List<Topic>()
            {
                new Topic()
                {
                    Id = 1,
                    Title = "Topic 1",
                    Products = new List<Product>()
                    {
                        new Product(){ Id = 1, Name = "Name 1", Price = 1 },
                        new Product(){ Id = 2, Name = "Name 2", Price = 100 }
                    }
                }
            };

        public List<Topic> GetTopics() 
        {
            return datasource;
        }

        public void AddTopic(Topic topic) 
        {
            datasource.Add(topic);
        }

        //public static List<Topic> GetTopicsNoProducts() 
        //{
        //    return null;
        //}

        // query language 
        // graphql 
    }
}
