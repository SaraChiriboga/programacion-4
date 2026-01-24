using ApiEscuela.Models;
using System.Linq;
using System.Web.Http;

namespace ApiEscuela.Controllers
{
    public class MateriasController : ApiController
    {
        public EscuelaContext db = new EscuelaContext();

        // GET: api/Materias
        public IHttpActionResult Get()
        {
            return Ok(db.Materias.ToList());
        }

        // GET: api/Materias/5
        public IHttpActionResult Get(int id)
        {
            var materia = db.Materias.Find(id);
            if (materia == null)
                return NotFound();
            return Ok(materia);
        }

        // POST: api/Materias
        public IHttpActionResult Post(Materia mat)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            db.Materias.Add(mat);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = mat.MateriaId }, mat);
        }

        // PUT: api/Materias/5
        public IHttpActionResult Put(int id, Materia mat)
        {
            var materia = db.Materias.Find(id);
            if (materia == null)
                return NotFound();

            materia.Nombre = mat.Nombre;
            materia.Creditos = mat.Creditos;
            db.SaveChanges();

            return Ok(materia);
        }

        // DELETE: api/Materias/5
        public IHttpActionResult Delete(int id)
        {
            var materia = db.Materias.Find(id);
            if (materia == null)
                return NotFound();

            db.Materias.Remove(materia);
            db.SaveChanges();

            return Ok("Materia eliminada correctamente");
        }
    }
}