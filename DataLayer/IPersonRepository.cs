using DataLayer.Models;
using System.Collections.Generic;

namespace DataLayer
{
	public interface IPersonRepository
	{
		IPersonEntity Save(IPersonEntity person);
		IEnumerable<IPersonEntity> GetAll();
	}
}
