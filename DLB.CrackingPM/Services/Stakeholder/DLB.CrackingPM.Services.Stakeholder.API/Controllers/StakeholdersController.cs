using DLB.CrackingPM.Services.Stakeholder.Domain.Interfaces;
using DLB.CrackingPM.Services.Stakeholder.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DLB.CrackingPM.Services.Stakeholder.API.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class StakeholdersController : ControllerBase
    {
        IStakeholderRepository _repo;

        public StakeholdersController(IStakeholderRepository repository)
        {
            _repo = repository;
        }
        // GET: api/<StakeholdersController>
        [HttpGet]
        public IEnumerable<Stakeholders> Get()
        {
            return _repo.GetAll();
        }

        // GET api/<StakeholdersController>/5
        [HttpGet("{id}")]
        public Stakeholders Get(string id)
        {
            return _repo.GetByCode(id);
        }

        [HttpGet]
        [Route("{id}/name")]
        public Stakeholders GetByName(string id)
        {
            return _repo.Filter(x => x.Name == id).FirstOrDefault();
        }

        // POST api/<StakeholdersController>
        [HttpPost]
        public void Post([FromBody] Stakeholders value)
        {
            _repo.Add(value);
        }

        // PUT api/<StakeholdersController>/5
        [HttpPut("{id}")]
        public void Put(Guid id, [FromBody] Stakeholders value)
        {
           // var obj = _repo.Filter(x => x.Id == id);
            _repo.Update(value);
        }

        // DELETE api/<StakeholdersController>/5
        [HttpDelete("{id}")]
        public void Delete(string id)
        {
            var obj = _repo.GetByCode(id);
            _repo.Delete(obj);
        }
    }
}
