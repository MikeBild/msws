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
  public class InvoicesController : ControllerBase
  {
    private readonly IDistributedCache _distributedCache;

    public InvoicesController(IDistributedCache distributedCache)
    {
      _distributedCache = distributedCache;
    }

    // GET api/invoices
    [HttpGet]
    public IEnumerable<string> Get()
    {
      return new string[] { "Invoice1", "Invoice2" };
    }

    // GET api/invoices/5
    [HttpGet("{id}")]
    public ActionResult<string> Get(int id)
    {
      return "value";
    }

    // POST api/Invoices
    [HttpPost]
    public void Post([FromBody] string value)
    {
    }

    // PUT api/invoices/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] string value)
    {
    }

    // DELETE api/invoices/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
    }
  }
}
