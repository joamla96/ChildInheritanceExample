using Models;
using System.Collections.Generic;
using System.Linq;

namespace DAL
{
	public class FooRepository
	{
		private readonly ICollection<Foo> Repo = new List<Foo>() {
			new Foo() { Id = 1, BarId = 1}
		};

		public Foo GetById(int Id)
		{
			return this.Repo.First(x => x.Id == Id);
		}
	}
}
