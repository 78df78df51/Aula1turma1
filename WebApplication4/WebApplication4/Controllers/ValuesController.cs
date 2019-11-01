using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace WebApplication4.Controllers
{
	[EnableCors(origins: "*", headers: "*", methods: "*")]

	public class Api2Controller : ApiController
	{
		// GET api/values


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
