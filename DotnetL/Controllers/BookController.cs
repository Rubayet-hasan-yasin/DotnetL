using DotnetL.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using MongoDB.Bson;
using MongoDB.Driver;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DotnetL.Controllers
{



    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        
        



        //public MongoClient client()
        //{
        //    const string connectionUri = "mongodb+srv://rubayethasanyasin1:O9tOMY0JrFMIqFBN@cluster0.f3udoep.mongodb.net/?retryWrites=true&w=majority";
        //    var settings = MongoClientSettings.FromConnectionString(connectionUri);
        //    settings.ServerApi = new ServerApi(ServerApiVersion.V1);

        //    var client = new MongoClient(settings);


        //    return client;


        //}
        
        
        


        // GET: api/<BookController>
        [HttpGet]
        public ActionResult GetBooks()
        {

            return Ok("Hello");


        }

        // GET api/<BookController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<BookController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<BookController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<BookController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
