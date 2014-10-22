using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.relation.pair.adj
{
	public class Irreflexive
		
	{
		static public bool Be<T>(
			Pair2<T> pair
			,
			IEqualityComparer<T> eq
		) {
			return !eq.Equals(pair.first, pair.second);
		}

		static public bool Not<T>(
			Pair2<T> pair
			,
			IEqualityComparer<T> eq)
		{

			return Be(pair, eq);
		}

	}
}
