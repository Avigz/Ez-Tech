using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using DatabaseApi;

namespace DatabaseApi.Controllers
{
    public class KundersController : ApiController
    {
        private EzDbContext db = new EzDbContext();

        // GET: api/Kunders
        public IQueryable<Kunder> GetKunder()
        {
            return db.Kunder;
        }

        // GET: api/Kunders/5
        [ResponseType(typeof(Kunder))]
        public async Task<IHttpActionResult> GetKunder(int id)
        {
            Kunder kunder = await db.Kunder.FindAsync(id);
            if (kunder == null)
            {
                return NotFound();
            }

            return Ok(kunder);
        }

        // PUT: api/Kunders/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutKunder(int id, Kunder kunder)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != kunder.KundeID)
            {
                return BadRequest();
            }

            db.Entry(kunder).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!KunderExists(id))
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

        // POST: api/Kunders
        [ResponseType(typeof(Kunder))]
        public async Task<IHttpActionResult> PostKunder(Kunder kunder)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Kunder.Add(kunder);

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (KunderExists(kunder.KundeID))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = kunder.KundeID }, kunder);
        }

        // DELETE: api/Kunders/5
        [ResponseType(typeof(Kunder))]
        public async Task<IHttpActionResult> DeleteKunder(int id)
        {
            Kunder kunder = await db.Kunder.FindAsync(id);
            if (kunder == null)
            {
                return NotFound();
            }

            db.Kunder.Remove(kunder);
            await db.SaveChangesAsync();

            return Ok(kunder);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool KunderExists(int id)
        {
            return db.Kunder.Count(e => e.KundeID == id) > 0;
        }
    }
}