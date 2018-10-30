using System;
using BLL.ModelExtensions;

namespace BLL
{
	public class FooRepository
	{
		private FooRepository() { }

		private static FooRepository instance;

		public static FooRepository Instance
		{
			get {
				if (instance == null) instance = new FooRepository();

				return instance;
			}
		}

		private DAL.FooRepository DAL = new DAL.FooRepository();

		public Foo GetById(int Id)
		{
			return (Foo)DAL.GetById(Id);
		}
	}
}
