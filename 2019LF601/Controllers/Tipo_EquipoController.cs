using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using _2019LF601.Models;

namespace _2019LF601.Controllers
{
    [ApiController]
    public class Tipo_Equipo : ControllerBase
    {
        private readonly _2019LF601Context _contexto;
        public Tipo_Equipo(_2019LF601Context miContexto)
        {
            this._contexto = miContexto;

        }
        [HttpGet]
        [Route("api/TipoEquipo")]
        public IActionResult Get()
        {
            var tipoEquipoList = _contexto.tipo_equipo;
            return Ok(tipoEquipoList);
        }
    }
}
