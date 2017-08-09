using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using OrcamentoApp.Models;

namespace OrcamentoApp.Controllers
{
    public class OrcadosController : ApiController
    {
        private Contexto db = new Contexto();

        // GET: api/Orcados
        public IQueryable<Orcado> GetOrcado()
        {
            return db.Orcado;
        }

        // GET: api/Orcados/5
        [ResponseType(typeof(Orcado))]
        public IHttpActionResult GetOrcado(string id)
        {
            Orcado orcado = db.Orcado.Find(id);
            if (orcado == null)
            {
                return NotFound();
            }

            return Ok(orcado);
        }

        // PUT: api/Orcados/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutOrcado(string id, Orcado orcado)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != orcado.CentroCustoCod)
            {
                return BadRequest();
            }

            db.Entry(orcado).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OrcadoExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Orcados
        [ResponseType(typeof(Orcado))]
        public IHttpActionResult PostOrcado(Orcado orcado)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Orcado.Add(orcado);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (OrcadoExists(orcado.CentroCustoCod))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = orcado.CentroCustoCod }, orcado);
        }

        // DELETE: api/Orcados/5
        [ResponseType(typeof(Orcado))]
        public IHttpActionResult DeleteOrcado(string id)
        {
            Orcado orcado = db.Orcado.Find(id);
            if (orcado == null)
            {
                return NotFound();
            }

            db.Orcado.Remove(orcado);
            db.SaveChanges();

            return Ok(orcado);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool OrcadoExists(string id)
        {
            return db.Orcado.Count(e => e.CentroCustoCod == id) > 0;
        }
    }
}