using System;
using System.Collections.Generic;
using DataLayer.Mock;
using DataLayer.Models;

namespace DataLayer
{
	public class PersonRepository : IPersonRepository
	{
		public IEnumerable<IPersonEntity> GetAll()
		{
			var list = new List<IPersonEntity>
			{
				new Person() { Name = "João" },
				new Person() { Name = "Souza" }
			};
			return list;
		}

		public IPersonEntity Save(IPersonEntity person)
		{
			throw new NotImplementedException();
		}
	}
}
