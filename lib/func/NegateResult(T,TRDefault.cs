using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.relation.func
{
	public class NegateResult<T,TDefault>
		:NegateResult<T>
		
		
		where TDefault:RelationI2<T>,new()
		
	{



		public NegateResult()
			:base(new TDefault())
		{
		}

		static public NegateResult<T, TDefault> Instance = SingletonByDefaultNew<NegateResult<T, TDefault>>.Instance;
					

	
	}
}
