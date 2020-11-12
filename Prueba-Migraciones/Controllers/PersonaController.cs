using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Prueba_Migraciones.Models;
using Prueba_Migraciones.Services;

namespace Prueba_Migraciones.Controllers
{
    //Para ejecutar el acceso ccon token vaya al postman y genere el token con las credenciales Correo y Password y descomente el Authorize
    //  [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class PersonaController : ControllerBase
    {

        private readonly IPersona _IPersona;

        public PersonaController(IPersona Sbpersona)
        {
            _IPersona = Sbpersona;

        }

        /// <summary>
        ///este metodo me trae todas las personas
        /// </summary>
        /// <returns></returns>
        [HttpGet]
     
        public IActionResult Get()
        {
            return Ok (
                _IPersona.GetAll()
            );
        }
      
        /// <summary>
        /// Este metodo me captura el id de la persona
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {

            return Ok(
                _IPersona.Get(id)
                
                );


        }

        /// <summary>
        ///este es el metodo de agregar persona
        /// </summary>
        /// <returns></returns>
        // POST api/values

        [HttpPost]
        public IActionResult Post([FromBody] Persona model)
        {

            return Ok(

                _IPersona.Add(model)


      );
        }


        /// <summary>
        /// este es el metodo de editar persona
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPut("{id}")]
        
        public IActionResult Put([FromBody] Persona model)
        {
            return Ok(

               _IPersona.Update(model)
   );

        }

        /// <summary>
        /// este es el metodo de eliminar persona
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
       
        public IActionResult Delete(int id)
        {
            return Ok(


                _IPersona.Delete(id)

          );

        }








    }
}
