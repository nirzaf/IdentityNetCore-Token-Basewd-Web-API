using System.Collections.Generic;
using IdentityNetCore.Models;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace IdentityNetCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        [Route(template:"List")]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        public List<Product> GetList()
        {
            var chair = new Product {Name = "Chair", Price = 100};
            var desk = new Product {Name = "Desk", Price = 50};

            return new List<Product> {chair, desk};
        }
    }
}