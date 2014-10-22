using nilnul.collection.set;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.relation
{
	public partial class Relation<T>
		:
		HashSet<Pair2<T>>
		,
		RelationI<T>
	{
		public Relation(IEnumerable<Pair2<T>> pairs,IEqualityComparer<T> eq)
			:base(pairs,new Pair2<T>.Eq(eq))
		{
		}

		IEqualityComparer<Pair2<T>> pairEq;

		private IEqualityComparer<T> _eq;

		public IEqualityComparer<T> eq
		{
			get { return _eq; }
			set { _eq = value; }
		}
		
		public Relation(IEqualityComparer<T> eq)
			:base(new Pair2<T>.Eq(eq))
		{
			this._eq = eq;
			this.pairEq = new Pair2<T>.Eq(eq);

		}

		public void add(T a,T b) {

			Add(new Pair2<T>(a, b));
		}


		public void addRange(IEnumerable<Pair2<T>> pairs) {

			addRange( pairs);
		}

	

		public HashSet<T> range() {

			return new HashSet<T>(
				this.Select(c=>c.second)
				,
				eq
				);


		
		}

		public HashSet<T> domain()
		{

			return new HashSet<T>(
				this.Select(c => c.first)
				,eq

				);

		}

		public HashSet<T> getDomain()
		{

			return new HashSet<T>(
				this.Select(c => c.first)
				, eq

				);

		}



		public HashSet<T> field() {
			var r = domain();
			r.UnionWith(range());
			return r;
			
		}

		public HashSet<T> getField() { 
			var r = domain();
			r.UnionWith(range());
			return r;

		}

		public Relation<T> toInverse() {

			return new Relation<T>(this.Select(c=>c.toInverse()), eq);
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
