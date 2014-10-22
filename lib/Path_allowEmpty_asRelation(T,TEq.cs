using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.relation
{
	/// <summary>
	/// path is a positve(non empty) string of pair, the start of each pair is the same as the end of the preceding pair.
	/// 
	/// a cycle or not
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <typeparam name="TEq"></typeparam>
	public partial class Path_allowEmpty_asRelation<T,TEq>
		:nilnul.relation.Path_allowEmpty_asRelation<T>

		where TEq:IEqualityComparer<T>,new()
	{
		public Path_allowEmpty_asRelation(
			IEnumerable<Pair2<T>> edges
			

		)
			:base(edges,SingletonByDefaultNew<TEq>.Instance )
		{
			

		}
	}
}

