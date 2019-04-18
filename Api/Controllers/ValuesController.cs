using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLayer;
using DataLayer;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ValuesController : ControllerBase
	{
		readonly PersonBL personBL;

		public ValuesController()
		{
			// Para melhora isso você pode utilizar injeção de dependência.
			IPersonRepository repository = new PersonRepository();
			this.personBL = new PersonBL(repository);
		}

		// GET api/values
		[HttpGet]
		public IActionResult Get()
		{
			return Ok(this.personBL.GetPeople());
		}
	}
}
