using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Cors;
using Microsoft.Extensions.Caching.Distributed;

namespace app.Controllers
{
  [Route("api/[controller]")]
  [EnableCors("AllowWebApp")]
  [ApiController]
  public class CardsController : ControllerBase
  {
    private readonly IDistributedCache _distributedCache;

    public CardsController(IDistributedCache distributedCache)
    {
      _distributedCache = distributedCache;
    }

    // GET api/cards
    [HttpGet]
    public IEnumerable<string> Get()
    {
      return new string[] { "Card1", "Card2" };
    }

    // GET api/cards/5
    [HttpGet("{id}")]
    public ActionResult<string> Get(int id)
    {
      return "value";
    }

    // POST api/Cards
    [HttpPost]
    public void Post([FromBody] string value)
    {
    }

    // PUT api/cards/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] string value)
    {
    }

    // DELETE api/cards/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
    }
  }
}
