using nilnul.obj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.relation
{
	static public class RelationX
	{

		static public HashSet<T> Field<T>(IEnumerable<Pair<T>> relation)
			where T:IEquatable<T>
		
		{
			var r = Domain(relation);
			r.UnionWith(Range(relation));
			return r;

		
		}


		static public HashSet<T> Domain<T>(IEnumerable<Pair<T>> relation)
			
		{

			return new HashSet<T>(
				relation.Select(c => c.first)

				);

		}

		static public HashSet<T> Domain<T>(IEnumerable<Pair2<T>> relation)
		{

			return new HashSet<T>(
				relation.Select(c => c.first)

				);

		}


		static public HashSet<T> Range<T>(IEnumerable<Pair<T>> relation)
		
		{

			return new HashSet<T>(
				relation.Select(c => c.second)

				);

		}

		static public IEnumerable<Pair<T>> StartWith<T>(IEnumerable<Pair<T>> pairs, T node)
		{

			return pairs.Where(c => c.startWith(node));

		}
		static public IEnumerable<Pair2<T>> StartWith<T>(IEnumerable<Pair2<T>> pairs, T node)
		{

			return pairs.Where(
				c=>
				nilnul.relation.pair.StartWith.Eval<T>(c, node)
			);

		}
		static public IEnumerable<Pair<T>> StartWith<T>(IEnumerable<Pair<T>> pairs, IEnumerable<T> node)
		{

			return node.SelectMany(c=> pairs.Where(d => d.startWith(c)));

		}

		static public IEnumerable<Pair2<T>> StartWith<T>(IEnumerable<Pair2<T>> pairs, IEnumerable<T> node)
		{

			return node.SelectMany(c => pairs.Where(d => pair.StartWith.Eval<T>(d,c)));

		}


		static public uint CardinalityOfRelation(params uint[] cardinalitiesOfSets) { 

			///it's the cardinality of powerst of  the cartesian product 
			///

			return Product.Eval(cardinalitiesOfSets);

			
		
		}
	}
}
