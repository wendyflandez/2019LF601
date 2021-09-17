using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using _2019LF601.Models;
using Microsoft.EntityFrameworkCore;

namespace _2019LF601.Controllers
{
    [ApiController]
    public class Estados_equipoController : ControllerBase
    {
        private readonly _2019LF601Context _contexto;
        public Estados_equipoController(_2019LF601Context miContexto)
        {
            this._contexto = miContexto;

        }
        [HttpGet]
        [Route("api/EstadoEquipo")]
        public IActionResult Get()
        {
            var estadoEquipoList = _contexto.Estados_equipo;
            return Ok(estadoEquipoList);
        }
    }
}
