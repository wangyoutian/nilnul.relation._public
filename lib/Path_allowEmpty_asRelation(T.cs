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
	public partial class Path_allowEmpty_asRelation<T>
		:nilnul.relation.Relation<T>
	{
		public Path_allowEmpty_asRelation(
			IEnumerable<Pair2<T>> edges
			,
			IEqualityComparer<T> elementEqComparer

		)
			:base(edges,elementEqComparer)
		{
			nilnul.bit.Assertion.True(Path_allowEmpty.Be(edges, elementEqComparer));

		}

		public Path_allowEmpty_asRelation(
			IEnumerable<Pair2<T>> edges
			
			)
		:base(
			edges,
			EqualityComparer<T>.Default
			)
		{

		}

		
	}
}

