using nilnul.collection.set;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.relation
{
	public partial class EquivalencePartition
	{

		static public nilnul.collection.set.s.Set<T,TEq> Eval<T,TEq>(Relation<T,TEq> relation)
			where TEq:IEqualityComparer<T>,new()
		{



			//var equivalencePartition = new collection.set.s.Disjoint<T,TEq>.Noun( new  nilnul.collection.set.s.Set<T,TEq>(
			//	relation.field().Select(c => new Set<T,TEq>(new[] { c }))
			//));
			var equivalencePartition =  new  nilnul.collection.set.s.Set<T,TEq>(
				relation.field().Select(c => new Set<T,TEq>(new[] { c }))
			);

			foreach (var pair in relation)
			{
				var set =nilnul.collection.set.s.Disjoint<T,TEq>.Noun.ContainerOf(equivalencePartition, pair.first);
				var setSecond = nilnul.collection.set.s.Disjoint<T,TEq>.Noun.ContainerOf(equivalencePartition, pair.second);

				if (! set.SetEquals( setSecond))
				{
					//merge the two sets.
					equivalencePartition.Remove(setSecond);
					set.UnionWith(setSecond);
				}
			}

			return equivalencePartition;

		}
	}
}
