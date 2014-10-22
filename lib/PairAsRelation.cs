using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.relation
{
	public partial class PairAsRelation
	{
		static public Relation<T> Eval<T>(Pair2<T> pair,IEqualityComparer<T> elementEq) {

			return new Relation<T>(new[] { pair },elementEq);
		
		}

		static public Relation<T> Eval<T, TEq>(
			Pair2<T> pair
			)
		where TEq:IEqualityComparer<T>,new()
		{
				return Eval(pair, SingletonByDefaultNew<TEq>.Instance);
		
		}
	}
}
