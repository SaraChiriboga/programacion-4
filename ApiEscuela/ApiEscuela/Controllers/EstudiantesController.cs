using ApiEscuela.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace ApiEscuela.Controllers
{
    public class EstudiantesController : ApiController
    {
        public EscuelaContext db = new EscuelaContext();
        // GET: Estudiantes
        public IHttpActionResult Get(int id)
        {
            var estudiante = db.Estudiantes.Find(id);
            if(estudiante == null)
            {
                return NotFound();
            }
            return Ok(db.Estudiantes.ToList());
        }

        //POST
        public IHttpActionResult Post(Estudiante est)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            db.Estudiantes.Add(est);
            db.SaveChanges();
            return CreatedAtRoute("DefaultApi", new { id = est.EstudianteId }, est);
        }

        //PUT
        public IHttpActionResult Put(int id, Estudiante est)
        {
            var estudiante = db.Estudiantes.Find(id);
            if (estudiante == null)
                return NotFound();

            estudiante.Nombre = est.Nombre;
            estudiante.Edad = est.Edad;
            db.SaveChanges();

            return Ok(estudiante);
        }

        //DELETE
        public IHttpActionResult Delete(int id)
        {
            var estudiante = db.Estudiantes.Find(id);
            if (estudiante == null)
                return NotFound();
            db.Estudiantes.Remove(estudiante);
            db.SaveChanges();

            return Ok("Estudiante eliminado correctamente");
        }

    }
}