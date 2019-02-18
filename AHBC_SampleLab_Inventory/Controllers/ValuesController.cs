using AHBC_SampleLab_Inventory.DAL;
using AHBC_SampleLab_Inventory.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AHBC_SampleLab_Inventory.Controllers
{
    public class ValuesController : ApiController
    {
        private InventoryDBContext db = new InventoryDBContext();

        // GET api/values
        public IHttpActionResult Get()
        {
            db.Inventories.ToList();
            return Ok(db.Inventories);

        }

        // GET api/values/5
        public IHttpActionResult Get(int? id)
        {
            int invValue = db.Inventories.Find(id).Quantity;

            return Ok(invValue);
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
