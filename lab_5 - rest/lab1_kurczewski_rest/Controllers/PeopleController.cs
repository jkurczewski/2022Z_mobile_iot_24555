using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Net.Http;

namespace lab1_kurczewski_rest {

    [Route("api/[controller]")]
    public class PeopleController : Controller {
        protected AzureDbContext db;
        public PeopleController(AzureDbContext db) {
            this.db = db;
        }
        // GET api/get
        [HttpGet]
        public IEnumerable<string> Get() {
            List<Person> people = new List<Person>();
            people = db.People.OrderBy(a => a.LastName).ToList();
            return (IEnumerable<string>)people ;
        }

        // GET api/get/5
        [HttpGet("{id}")]
        public string Get(int id) {
            Person person = new Person();
            person = (Person)db.People.Where(a => a.PersonId == id);
            return person;
        }

        // POST api/post
        [HttpPost]
        public void Post([FromBody] string value) {
        }

        // PUT api/put/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value) {
            db.Update(id, value);
        }

        // DELETE api/delete/5
        [HttpDelete("{id}")]
        public void Delete(int id) {
            db.Remove(id);
        }
    }
}
