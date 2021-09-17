using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using _2019LF601.Models;

namespace _2019LF601.Controllers
{
    [ApiController]
    public class equiposController : ControllerBase
    {
        private readonly _2019LF601Context _contexto;
        public equiposController(_2019LF601Context miContexto)
        {
            this._contexto = miContexto;

        }
        [HttpGet]
        [Route("api/equipos")]
        public IActionResult Get()
        {
            var equiposList = _contexto.equipos;
            return Ok(equiposList);
        }
    }
}
