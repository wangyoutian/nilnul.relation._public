using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.relation
{
	public class Range
	{
		static public HashSet<T> Eval<T>(IEnumerable<Pair2<T>> relation)
		{

			return Eval<T>(relation, EqualityComparer<T>.Default);
			

		}

		static public HashSet<T> Eval<T>(IEnumerable<Pair2<T>> relation, IEqualityComparer<T> elementEq)
		{

			return new HashSet<T>(

				relation.Select(c => c.second)
				,
				elementEq

			);

		}

		static public HashSet<T> Eval<T, TEq>(
			IEnumerable<Pair2<T>> relation
			
		)
		where TEq:IEqualityComparer<T>,new()
		{

			return Eval<T>(relation, SingletonByDefaultNew<TEq>.Instance);
		
		
		}
	}
}
