using MagicVilla_VillaAPI.Data;
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
       public ActionResult<IEnumerable<VillaDTO>> GetVillas()
       {
            return Ok(VillaStore.villaList);
       }
        [HttpGet("id")]
        public ActionResult<VillaDTO> GetVilla(int Id)
        {
            if (Id ==0 )
            {
                return BadRequest();
            }
            var villa = VillaStore.villaList.FirstOrDefault(u => u.Id == Id);
            if (villa == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(villa);
            }
        }
    }
}
