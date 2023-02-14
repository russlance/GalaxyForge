using GalaxyForge.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GalaxyForge.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GalaxyController : ControllerBase
    {
        private GalaxyDataAccessLayer galaxy = new GalaxyDataAccessLayer();

        /*
         [HttpGet]
        [Route("api/GalacticSector/Index")]
        public IEnumerable<GalacticSector> GetGalacticSectors()
        {
            return galaxy.GetAllGalacticSectors();
        }

        [HttpGet]
        [Route("api/{}/Details/{id}")]
        public GalacticSector
         */
    }
}

/*
          // GET: api/<GalaxyController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<GalaxyController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<GalaxyController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<GalaxyController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<GalaxyController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
  */