using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Hosting;
using app.Models;
using app.Repositories;

namespace app.Controllers
{
  [Route("api/[controller]")]
  [EnableCors("AllowWebApi")]
  [ApiController]
  public class ProductsController : ControllerBase
  {
    private readonly IHostingEnvironment _hostingEnvironment;
    private readonly IProductsRepository _productRepository;

    public ProductsController(IHostingEnvironment hostingEnvironment, IProductsRepository productRepository)
    {
      _hostingEnvironment = hostingEnvironment;
      _productRepository = productRepository;
    }

    // GET api/products
    [HttpGet]
    public JsonResult Get()
    {
      var products = _productRepository.Load();

      return new JsonResult(new { items = products });
    }

    // GET api/products/5
    [HttpGet("{id}")]
    public ActionResult<Product> Get(string id)
    {
      var products = _productRepository.Load();

      return products.FirstOrDefault(product => product.Id == id);
    }

    // POST api/products
    [HttpPost]
    public Product Post(Product product)
    {
      product.Id = Guid.NewGuid().ToString();

      var products = _productRepository.Load();
      var newProducts = products.Append(product);
      _productRepository.Save(newProducts);

      return product;
    }

    // PUT api/products/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] string value)
    {
    }

    // DELETE api/products/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
    }
  }
}
