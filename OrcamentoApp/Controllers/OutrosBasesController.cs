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
    public class OutrosBasesController : ApiController
    {
        private Contexto db = new Contexto();

        // GET: api/OutrosBases
        public IQueryable<OutrosBase> GetOutrosBase()
        {
            return db.OutrosBase;
        }

        // GET: api/OutrosBases/5
        [ResponseType(typeof(OutrosBase))]
        public IHttpActionResult GetOutrosBase(string id)
        {
            OutrosBase outrosBase = db.OutrosBase.Find(id);
            if (outrosBase == null)
            {
                return NotFound();
            }

            return Ok(outrosBase);
        }

        // PUT: api/OutrosBases/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutOutrosBase(string id, OutrosBase outrosBase)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != outrosBase.FuncionarioMatricula)
            {
                return BadRequest();
            }

            db.Entry(outrosBase).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OutrosBaseExists(id))
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

        // POST: api/OutrosBases
        [ResponseType(typeof(OutrosBase))]
        public IHttpActionResult PostOutrosBase(OutrosBase outrosBase)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.OutrosBase.Add(outrosBase);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (OutrosBaseExists(outrosBase.FuncionarioMatricula))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = outrosBase.FuncionarioMatricula }, outrosBase);
        }

        // DELETE: api/OutrosBases/5
        [ResponseType(typeof(OutrosBase))]
        public IHttpActionResult DeleteOutrosBase(string id)
        {
            OutrosBase outrosBase = db.OutrosBase.Find(id);
            if (outrosBase == null)
            {
                return NotFound();
            }

            db.OutrosBase.Remove(outrosBase);
            db.SaveChanges();

            return Ok(outrosBase);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool OutrosBaseExists(string id)
        {
            return db.OutrosBase.Count(e => e.FuncionarioMatricula == id) > 0;
        }
    }
}