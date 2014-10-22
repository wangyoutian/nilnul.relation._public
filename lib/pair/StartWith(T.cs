using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.relation.pair
{
	public partial class StartWith
	{

		static public bool Eval<T>(Pair2<T> pair, T first)
		{

			return Eval<T>(pair, first, EqualityComparer<T>.Default);
		}
		static public bool Eval<T>(Pair2<T> pair, T first, IEqualityComparer<T> elementEq) {

			return elementEq.Equals(pair.first, first);
		
		}



		static public bool Eval<T, TEq>(
			Pair2<T> pair
			,
			T first
			
			)
			where TEq:IEqualityComparer<T>,new()
		{

			return Eval<T>(pair, first, SingletonByDefaultNew<TEq>.Instance);
		
		}
	}
}
