using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.relation.pair
{
	public partial class Reflexive<T,TEq>
		:Reflexive<T>
		where TEq:IEqualityComparer<T>,new()
	{
		public Reflexive()
			:base(SingletonByDefaultNew<TEq>.Instance)
		{

		}
	}
}
