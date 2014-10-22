using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.relation.pair
{
	public partial class Eq<T,TEq>
		:Eq<T>
		where TEq:IEqualityComparer<T>,new()
	{
		
		
		public Eq()
			:base(SingletonByDefaultNew<TEq>.Instance)
		{
			

		}
		
	}
}
