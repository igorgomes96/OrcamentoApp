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
    public class PATsController : ApiController
    {
        private Contexto db = new Contexto();

        // GET: api/PATs
        public IQueryable<PAT> GetPAT()
        {
            return db.PAT;
        }

        // GET: api/PATs/5
        [ResponseType(typeof(PAT))]
        public IHttpActionResult GetPAT(int id)
        {
            PAT pAT = db.PAT.Find(id);
            if (pAT == null)
            {
                return NotFound();
            }

            return Ok(pAT);
        }

        // PUT: api/PATs/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutPAT(int id, PAT pAT)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != pAT.CargaHoraria)
            {
                return BadRequest();
            }

            db.Entry(pAT).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PATExists(id))
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

        // POST: api/PATs
        [ResponseType(typeof(PAT))]
        public IHttpActionResult PostPAT(PAT pAT)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.PAT.Add(pAT);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (PATExists(pAT.CargaHoraria))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = pAT.CargaHoraria }, pAT);
        }

        // DELETE: api/PATs/5
        [ResponseType(typeof(PAT))]
        public IHttpActionResult DeletePAT(int id)
        {
            PAT pAT = db.PAT.Find(id);
            if (pAT == null)
            {
                return NotFound();
            }

            db.PAT.Remove(pAT);
            db.SaveChanges();

            return Ok(pAT);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool PATExists(int id)
        {
            return db.PAT.Count(e => e.CargaHoraria == id) > 0;
        }
    }
}