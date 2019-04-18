using BusinessLayer.Models;
using DataLayer;
using DataLayer.Models;
using System.Collections.Generic;

namespace BusinessLayer
{
	public class PersonBL
	{
		private IPersonRepository personRepository;


		public PersonBL(IPersonRepository personRepository)
		{
			this.personRepository = personRepository;
		}

		public IPersonEntity CreatePerson(PersonDTO person)
		{
			return this.personRepository.Save(person);
		}

		public IEnumerable<IPersonEntity> GetPeople()
		{
			return this.personRepository.GetAll();
		}
	}
}
