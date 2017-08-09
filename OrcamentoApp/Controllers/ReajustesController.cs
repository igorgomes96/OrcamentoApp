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
    public class ReajustesController : ApiController
    {
        private Contexto db = new Contexto();

        // GET: api/Reajustes
        public IQueryable<Reajuste> GetReajuste()
        {
            return db.Reajuste;
        }

        // GET: api/Reajustes/5
        [ResponseType(typeof(Reajuste))]
        public IHttpActionResult GetReajuste(int id)
        {
            Reajuste reajuste = db.Reajuste.Find(id);
            if (reajuste == null)
            {
                return NotFound();
            }

            return Ok(reajuste);
        }

        // PUT: api/Reajustes/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutReajuste(int id, Reajuste reajuste)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != reajuste.Ano)
            {
                return BadRequest();
            }

            db.Entry(reajuste).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ReajusteExists(id))
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

        // POST: api/Reajustes
        [ResponseType(typeof(Reajuste))]
        public IHttpActionResult PostReajuste(Reajuste reajuste)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Reajuste.Add(reajuste);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (ReajusteExists(reajuste.Ano))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = reajuste.Ano }, reajuste);
        }

        // DELETE: api/Reajustes/5
        [ResponseType(typeof(Reajuste))]
        public IHttpActionResult DeleteReajuste(int id)
        {
            Reajuste reajuste = db.Reajuste.Find(id);
            if (reajuste == null)
            {
                return NotFound();
            }

            db.Reajuste.Remove(reajuste);
            db.SaveChanges();

            return Ok(reajuste);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ReajusteExists(int id)
        {
            return db.Reajuste.Count(e => e.Ano == id) > 0;
        }
    }
}