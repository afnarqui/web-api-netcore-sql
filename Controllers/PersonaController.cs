using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace prueba.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("permisos")]
    public class PersonaController : ControllerBase
    {
        [HttpGet]
        public ActionResult Get()
        {
           using (Models.pruebaContext db = new Models.pruebaContext())
            {
                var listaPersona = (from d in db.Persona
                                    select d).ToList();

                return Ok(listaPersona);
            }
        }


        [HttpPost]
        public ActionResult Post([FromBody] Models.Request.PersonaRequest model)
        {
            using(Models.pruebaContext db = new Models.pruebaContext())
            {
                Models.Persona copiaPersona = new Models.Persona();
                copiaPersona.Nombre = model.Nombre;
                copiaPersona.Edad = model.Edad;
                copiaPersona.Date = model.Date;
                copiaPersona.CreatedAt = model.CreatedAt;
                copiaPersona.UpdatedAt = model.UpdatedAt;
                db.Persona.Add(copiaPersona);
                db.SaveChanges();
            }

            return Ok();
        }

        [HttpPut]
        public ActionResult Post([FromBody] Models.Request.PersonaEditRequest model)
        {
            using (Models.pruebaContext db = new Models.pruebaContext())
            {
                Models.Persona copiaPersona = db.Persona.Find(model.Id);
                copiaPersona.Nombre = model.Nombre;
                copiaPersona.Edad = model.Edad;
                copiaPersona.Date = model.Date;
                copiaPersona.CreatedAt = model.CreatedAt;
                copiaPersona.UpdatedAt = model.UpdatedAt;
                db.Entry(copiaPersona).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                db.SaveChanges();
            }

            return Ok();
        }

        [HttpDelete]
        public ActionResult Delete([FromBody] Models.Request.PersonaEditRequest model)
        {
            using (Models.pruebaContext db = new Models.pruebaContext())
            {
                Models.Persona copiaPersona = db.Persona.Find(model.Id);
                db.Persona.Remove(copiaPersona);
                db.SaveChanges();
            }

            return Ok();
        }
    }
}