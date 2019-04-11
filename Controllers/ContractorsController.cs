using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using contracted.Models;
using contracted.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace contracted.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class ContractorsController : ControllerBase
  {
    private readonly ContractorsRepository _cr;
    public ContractorsController(ContractorsRepository cr)
    {
      _cr = cr;
    }
    // GET api/values
    [HttpGet]
    public ActionResult<IEnumerable<Contractor>> Get()
    {
      return Ok(_cr.GetAll());
    }

    // GET api/values/5
    [HttpGet("{id}")]
    public ActionResult<Contractor> GetOne(string Id)
    {
      return Ok(_cr.GetById(Id));
    }

    // POST api/values
    [HttpPost]
    public void Post([FromBody] string value)
    {
    }

    // PUT api/values/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] string value)
    {
    }

    // DELETE api/values/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
    }
  }
}
