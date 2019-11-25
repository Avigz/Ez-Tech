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
using WebApplication1;

namespace WebApplication1.Controllers
{
    public class HjælpereController : ApiController
    {
        private ClientDbContext db = new ClientDbContext();

        // GET: api/Hjælpere
        public IQueryable<Hjælpere> GetHjælpere()
        {
            return db.Hjælpere;
        }

        // GET: api/Hjælpere/5
        [ResponseType(typeof(Hjælpere))]
        public IHttpActionResult GetHjælpere(int id)
        {
            Hjælpere hjælpere = db.Hjælpere.Find(id);
            if (hjælpere == null)
            {
                return NotFound();
            }

            return Ok(hjælpere);
        }

        // PUT: api/Hjælpere/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutHjælpere(int id, Hjælpere hjælpere)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != hjælpere.ID)
            {
                return BadRequest();
            }

            db.Entry(hjælpere).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HjælpereExists(id))
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

        // POST: api/Hjælpere
        [ResponseType(typeof(Hjælpere))]
        public IHttpActionResult PostHjælpere(Hjælpere hjælpere)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Hjælpere.Add(hjælpere);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (HjælpereExists(hjælpere.ID))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = hjælpere.ID }, hjælpere);
        }

        // DELETE: api/Hjælpere/5
        [ResponseType(typeof(Hjælpere))]
        public IHttpActionResult DeleteHjælpere(int id)
        {
            Hjælpere hjælpere = db.Hjælpere.Find(id);
            if (hjælpere == null)
            {
                return NotFound();
            }

            db.Hjælpere.Remove(hjælpere);
            db.SaveChanges();

            return Ok(hjælpere);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool HjælpereExists(int id)
        {
            return db.Hjælpere.Count(e => e.ID == id) > 0;
        }
    }
}