using System;
using BLL.ModelExtensions;

namespace BLL
{
	public class BarRepository
	{

		private BarRepository() { }

		private static BarRepository instance;

		public static BarRepository Instance { get {
				if (instance == null) instance = new BarRepository();

				return instance;
			} }


		private DAL.BarRepository DAL = new DAL.BarRepository();

		public Bar GetById(int Id)
		{
			return (Bar)DAL.GetById(Id);
		}
	}
}
