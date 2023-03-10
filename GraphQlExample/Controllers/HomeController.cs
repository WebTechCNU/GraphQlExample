using GraphQlExample.Repositories;
using GraphQlExample.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace GraphQlExample.Controllers
{
    [Route("Home")]
    public class HomeController : Controller
    {
        private IRepository repository;

        public HomeController(IRepository repository)
        {
            this.repository = repository;
        }

        public IActionResult Index()
        {
            return new JsonResult(repository.GetTopics());
        }
    } // overfetching, underfetching 
}
