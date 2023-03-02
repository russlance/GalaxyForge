using GalaxyForge.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GalaxyForge.Controllers
{
    public class GalacticSectorController : Controller
    {
        private GalacticSectorDataAccessLayer galacticSectorDAL = new GalacticSectorDataAccessLayer();

        [HttpGet]
        [Route("api/GalacticSector/GetAllGalacticSectors")]
        public IEnumerable<GalacticSector> GetAllGalacticSectors()
        {
            Debug.WriteLine("getting info from db");
            return galacticSectorDAL.GetAllGalacticSectors();
        }

        [HttpPost]
        [Route("api/GalacticSector/Create")]
        public int Create(GalacticSector galacticSector)
        {
            return galacticSectorDAL.AddGalacticSector(galacticSector);
        }
    }
}

/*
          // GET: api/<GalacticSectorController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<GalacticSectorController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<GalacticSectorController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<GalacticSectorController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<GalacticSectorController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
  */