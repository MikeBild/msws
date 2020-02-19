using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using app.Models;

namespace app.Repositories
{
  public interface IProductsRepository
  {
    IEnumerable<Product> Load();
    void Save(IEnumerable<Product> products);
  }

  public class ProductsRepository : IProductsRepository
  {
    public IEnumerable<Product> Load()
    {
      var basePath = Environment.GetEnvironmentVariable("FILE_BASE_PATH");
      var json = System.IO.File.ReadAllText(basePath + "/products.json");
      var products = JsonConvert.DeserializeObject<Product[]>(json);

      return products;
    }

    public void Save(IEnumerable<Product> products)
    {
      var basePath = Environment.GetEnvironmentVariable("FILE_BASE_PATH");
      var newJson = JsonConvert.SerializeObject(products);
      System.IO.File.WriteAllText(basePath + "/products.json", newJson);
    }

  }

}