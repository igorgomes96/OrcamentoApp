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
    public class ReajConvenioMedicosController : ApiController
    {
        private Contexto db = new Contexto();

        // GET: api/ReajConvenioMedicos
        public IQueryable<ReajConvenioMed> GetReajConvenioMed()
        {
            return db.ReajConvenioMed;
        }

        // GET: api/ReajConvenioMedicos/5
        [ResponseType(typeof(ReajConvenioMed))]
        public IHttpActionResult GetReajConvenioMed(int id)
        {
            ReajConvenioMed reajConvenioMed = db.ReajConvenioMed.Find(id);
            if (reajConvenioMed == null)
            {
                return NotFound();
            }

            return Ok(reajConvenioMed);
        }

        // PUT: api/ReajConvenioMedicos/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutReajConvenioMed(int id, ReajConvenioMed reajConvenioMed)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != reajConvenioMed.Ano)
            {
                return BadRequest();
            }

            db.Entry(reajConvenioMed).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ReajConvenioMedExists(id))
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

        // POST: api/ReajConvenioMedicos
        [ResponseType(typeof(ReajConvenioMed))]
        public IHttpActionResult PostReajConvenioMed(ReajConvenioMed reajConvenioMed)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.ReajConvenioMed.Add(reajConvenioMed);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (ReajConvenioMedExists(reajConvenioMed.Ano))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = reajConvenioMed.Ano }, reajConvenioMed);
        }

        // DELETE: api/ReajConvenioMedicos/5
        [ResponseType(typeof(ReajConvenioMed))]
        public IHttpActionResult DeleteReajConvenioMed(int id)
        {
            ReajConvenioMed reajConvenioMed = db.ReajConvenioMed.Find(id);
            if (reajConvenioMed == null)
            {
                return NotFound();
            }

            db.ReajConvenioMed.Remove(reajConvenioMed);
            db.SaveChanges();

            return Ok(reajConvenioMed);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ReajConvenioMedExists(int id)
        {
            return db.ReajConvenioMed.Count(e => e.Ano == id) > 0;
        }
    }
}