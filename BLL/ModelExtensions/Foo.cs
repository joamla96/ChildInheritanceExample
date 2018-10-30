using System;
using System.Collections.Generic;
using System.Text;
using Models;

namespace BLL.ModelExtensions
{
	public class Foo : Models.Foo
	{
		public Bar Bar
		{
			get {
				return BarRepository.Instance.GetById(this.BarId);
			}
		}
	}
}
