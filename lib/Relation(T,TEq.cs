using nilnul.collection.set;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.relation
{
	public partial class Relation<T,TEq>
		:
		nilnul.collection.set.Set<Pair<T,TEq>,Pair<T,TEq>.Eq>
		,
		RelationI<T,TEq>
		//where T:IEquatable<T>
		where TEq:IEqualityComparer<T>,new()
	{
		static public TEq NodeEq = SingletonByDefaultNew<TEq>.Instance;

		public Relation()
		{

		}


		public Relation(IEnumerable<Pair<T,TEq>> pairs)
			:base(pairs)
		{
		}


		public void addRange(IEnumerable<Pair<T,TEq>> pairs) {

			addRange( pairs);
		}

		




		public Set<T,TEq> range() {

			return new Set<T,TEq>(
				this.Select(c=>c.second)
				
				);


		
		}

		public Set<T,TEq> domain()
		{

			return new Set<T,TEq>(
				this.Select(c => c.first)

				);

		}

		public Set<T,TEq> field() {
			var r = domain();
			r.UnionWith(range());
			return r;
			
		}

		public Relation<T,TEq> toInverse() {

			return new Relation<T,TEq>(this.Select(c=>c.toInverse()));
		}




		static public Set<T,TEq> Field(IEnumerable<Pair<T,TEq>> arcs)
			
		{

			var r = new Set<T,TEq>();
			foreach (var item in arcs)
			{
				r.Add(item.first);
				r.Add(item.second);

			}
			return r;


		}


		public bool contains(T first, T second)
		{
			return (this as HashSet<Pair<T>>).Any(c=>c.Equals(first) && c.Equals(second));
		}

		public IEnumerable<Pair<T,TEq>> beginWith(T start) {

			return this.Where(c => c.startWith(start));
		
		}

		public IEnumerable<Pair<T,TEq>> beginWith(IEnumerable<T> starts)
		{

			return starts.SelectMany(c=>beginWith(c));

		}

		public IEnumerable<Pair<T,TEq>> endWith(T start)
		{

			return this.Where(c => c.endWith(start));

		}

		public IEnumerable<Pair<T,TEq>> endWith(IEnumerable<T> starts)
		{

			return starts.SelectMany(c => endWith(c));

		}

		
	}
}
