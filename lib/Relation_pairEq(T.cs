using nilnul.collection.set;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.relation
{
	public partial class Relation_pairEq<T>
		:
		HashSet<Pair2<T>>
		,
		RelationI<T>
	{

	
		public Relation_pairEq(IEqualityComparer<Pair2<T>> eq)
			:base(eq)
		{
			

		}

		public Relation_pairEq(IEnumerable<Pair2<T>> pairs,IEqualityComparer<Pair2<T>> eq)
			:base(pairs,eq)
		{
		}


		public void addRange(IEnumerable<Pair2<T>> pairs) {

			addRange( pairs);
		}

		




		public HashSet<T> range() {

			return new HashSet<T>(
				this.Select(c=>c.second)
				,
				this.Comparer
				);


		
		}

		public HashSet<T> domain()
		{

			return new HashSet<T>(
				this.Select(c => c.first)
				,eq

				);

		}

		public HashSet<T> field() {
			var r = domain();
			r.UnionWith(range());
			return r;
			
		}

		public Relation_pairEq<T> toInverse() {

			return new Relation_pairEq<T>(this.Select(c=>c.toInverse()), eq);
		}



		public bool contains(T first, T second)
		{
			return (this as HashSet<Pair2<T>>).Any(c=>c.Equals(first) && c.Equals(second));
		}

		public IEnumerable<Pair2<T>> beginWith(T start) {

			return this.Where(c => eq.Equals(c.first,start));// c.startWith(start));
		
		}

		public IEnumerable<Pair2<T>> beginWith(IEnumerable<T> starts)
		{

			return starts.SelectMany(c=>beginWith(c));

		}

		public IEnumerable<Pair2<T>> endWith(T start)
		{

			return this.Where(c => eq.Equals(c.second,start));// c.endWith(start));

		}

		public IEnumerable<Pair2<T>> endWith(IEnumerable<T> starts)
		{

			return starts.SelectMany(c => endWith(c));

		}

		
	}
}
