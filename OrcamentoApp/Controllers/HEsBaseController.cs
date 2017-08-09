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
    public class HEsBaseController : ApiController
    {
        private Contexto db = new Contexto();

        // GET: api/HEsBase
        public IQueryable<HEBase> GetHEBase()
        {
            return db.HEBase;
        }

        // GET: api/HEsBase/5
        [ResponseType(typeof(HEBase))]
        public IHttpActionResult GetHEBase(string id)
        {
            HEBase hEBase = db.HEBase.Find(id);
            if (hEBase == null)
            {
                return NotFound();
            }

            return Ok(hEBase);
        }

        // PUT: api/HEsBase/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutHEBase(string id, HEBase hEBase)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != hEBase.FuncionarioMatricula)
            {
                return BadRequest();
            }

            db.Entry(hEBase).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HEBaseExists(id))
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

        // POST: api/HEsBase
        [ResponseType(typeof(HEBase))]
        public IHttpActionResult PostHEBase(HEBase hEBase)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.HEBase.Add(hEBase);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (HEBaseExists(hEBase.FuncionarioMatricula))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = hEBase.FuncionarioMatricula }, hEBase);
        }

        // DELETE: api/HEsBase/5
        [ResponseType(typeof(HEBase))]
        public IHttpActionResult DeleteHEBase(string id)
        {
            HEBase hEBase = db.HEBase.Find(id);
            if (hEBase == null)
            {
                return NotFound();
            }

            db.HEBase.Remove(hEBase);
            db.SaveChanges();

            return Ok(hEBase);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool HEBaseExists(string id)
        {
            return db.HEBase.Count(e => e.FuncionarioMatricula == id) > 0;
        }
    }
}