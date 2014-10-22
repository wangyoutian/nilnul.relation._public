using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.relation
{
	/*The Floyd–Warshall algorithm[5] can be used to compute the transitive closure of any directed graph, which gives rise to the reachability relation as in the definition, above*/
	public partial class Reachable
	{
		static public bool Be<T,TEq>(
			Relation<T,TEq> relation,
			T start,
			T end
		)
		where TEq:IEqualityComparer<T>,new()
		{



			throw new NotImplementedException();
		
		}
	}
}
