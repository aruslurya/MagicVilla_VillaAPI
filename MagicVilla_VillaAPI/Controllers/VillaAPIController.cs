using MagicVilla_VillaAPI.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MagicVilla_VillaAPI.Controllers
{
    [Route("api/VillaAPI")]
    [ApiController]
    public class VillaAPIController : Controller
    {
        [HttpGet]
       public IEnumerable<Villa> GetVillas()
       {
            return new List<Villa>
            {
                new Villa{Id=1,Name = "Pool View"},
                new Villa{Id = 2, Name = "Beach View"}
            };
       }
    }
}
