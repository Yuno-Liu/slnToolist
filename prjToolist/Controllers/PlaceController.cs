﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace prjToolist.Controllers
{
    public class PlaceController : ApiController
    {
        
        // GET: api/Place
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Place/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Place
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Place/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Place/5
        public void Delete(int id)
        {
        }
    }
}