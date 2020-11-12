using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Prueba_Migraciones.Models;
using Prueba_Migraciones.Services;

namespace Prueba_Migraciones.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SolicitudController : ControllerBase
    {


        private readonly ISolicitudes _ISolicitud;

        public SolicitudController(ISolicitudes solicitudes)
        {
            _ISolicitud = solicitudes;

        }

        /// <summary>
        /// este metodo me trae todas las solicitudes
        /// </summary>
        /// <returns></returns>


        [HttpGet]
        public IActionResult Get()
        {
            return Ok(
                _ISolicitud.GetAll()
            );
        }
        /// <summary>
        /// Aqui capturo el id de la solicitud
        /// </summary>
        /// <returns></returns>
        [HttpGet("{id}")]
        

       

        public IActionResult Get(int id)
        {

            return Ok(
                _ISolicitud.Get(id)

                );


        }


        /// <summary>
        /// este es el metodo de agregar una solicitud
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Post([FromBody] Solicitud model)
        {

            return Ok(

                _ISolicitud.Add(model)


      );
        }


        /// <summary>
        /// este es el metodo de editar una solicitud
        /// </summary>
        /// <returns></returns>

        [HttpPut("{id}")]
        public IActionResult Put([FromBody] Solicitud model)
        {
            return Ok(

               _ISolicitud.Update(model)
   );

        }

        /// <summary>
        /// este es el metodo de eliminar una solicitud
        /// </summary>
 
        /// <returns></returns>

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok(


                _ISolicitud.Delete(id)

          );

        }
    }
}
