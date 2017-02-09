using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ProductAPI.Models;

namespace ProductAPI.Controllers
{
    public class ProductController : ApiController
    {
        Product[] products = new Product[]
        {
            new Product {ID=1,Name="Wildcraft",Category="backpack",Price=20 },
            new Product {ID=2,Name="Michelkores",Category="purse",Price=80 }
        };

        public IEnumerable<Product> GetAll()
        {
            return products;
        }
    }
}
