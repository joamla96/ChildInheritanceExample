using BLL;
using System;

namespace UI.CLI
{
	class Program
	{
		private static BarRepository barRepo = BarRepository.Instance;
		private static FooRepository fooRepo = FooRepository.Instance;

		static void Main(string[] args)
		{
			var foo = fooRepo.GetById(1);

			Console.ReadLine();
		}
	}
}
