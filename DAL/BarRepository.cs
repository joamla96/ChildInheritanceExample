using Models;
using System.Collections.Generic;
using System.Linq;

namespace DAL
{
	public class BarRepository
	{
		private readonly ICollection<Bar> Repo = new List<Bar>() {
			new Bar() { Id = 1 }
		};

		public Bar GetById(int Id)
		{
			return this.Repo.First(x => x.Id == Id);
		}
	}
}
