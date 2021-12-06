using MamtakNetApp.Entities;
using MamtakNetApp.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MamtakNetApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {

        private readonly ICandyService _candyService;


        [HttpGet]
        [ActionName("AddCandy")]
        public async Task<ActionResult> AddToFavorites(Candy candy)
        {
            await _candyService.AddCandy(candy);
            return Ok();
        }
    }
}
