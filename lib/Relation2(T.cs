using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.relation
{
	/// <summary>
	/// If more than one arrow came out of any point in the first column, then f would be a relation, but not a function.
	/// </summary>
	
		public partial class Relation2<T>
			:

			nilnul.collection.set.Set<Pair2<T>>

			//HashSet<Pair_withNoEq.Pair<T>>
			,
			RelationI<T>
		{
			public Relation2(IEqualityComparer<T> eq)
				: base(new Pair2<T>.Eq(eq))
			{
				this._eq = eq;
				this.pairEq = new Pair_withNoEq.Pair<T>.Eq(eq);
				this.pairEqComparer = new Pair2<T>.Eq(eq);

			}

			public Relation2(IEnumerable<Pair2<T>> pairs, IEqualityComparer<T> eq)
				: base(pairs, new Pair2<T>.Eq(eq))
			{
				

				this._eq = eq;


			}
			public Relation2(IEnumerable<Pair2<T>> pairs)
				:this(pairs,EqualityComparer<T>.Default)
			{

			}

			public Relation2()
				:this(EqualityComparer<T>.Default)
			{
				

			}

		



			IEqualityComparer<Pair_withNoEq.Pair<T>> pairEq;
			Pair2<T>.Eq _pairEqComparer;

			public Pair2<T>.Eq pairEqComparer
			{
				get { return _pairEqComparer; }
				set { _pairEqComparer = value; }
			}
			


			private IEqualityComparer<T> _eq;

			public IEqualityComparer<T> eq
			{
				get { return _eq; }
				set { _eq = value; }
			}
			public IEqualityComparer<T> elementEq
			{
				get { return _eq; }
				set { _eq = value; }
			}



			//public void addRange(IEnumerable<Pair_withNoEq.Pair<T>> pairs)
			//{
			//	foreach (var item in pairs)
			//	{
			//		Add(item);
			//	}
				
			//}

			public void add(T first,T second) {
				Add(new Pair2<T>(first, second));
			}

			public HashSet<T> range()
			{

				return new HashSet<T>(
					this.Select(c => c.second)
					,
					eq
					);



			}

			public HashSet<T> domain()
			{

				return new HashSet<T>(
					this.Select(c => c.first)
					, eq

					);

			}

			public HashSet<T> getDomain()
			{

				return new HashSet<T>(
					this.Select(c => c.first)
					, eq

					);

			}



			public HashSet<T> field()
			{
				var r = domain();
				r.UnionWith(range());
				return r;

			}

			public HashSet<T> getField()
			{
				var r = domain();
				r.UnionWith(range());
				return r;

			}

			public Relation2<T> toInverse()
			{

				return new Relation2<T>(this.Select(c => c.toInverse()), eq);
			}



			public bool contains(T first, T second)
			{
				return (this as HashSet<Pair2<T>>).Any(c => eq.Equals(c.first,first) && eq.Equals(c.second,second));
			}

			public IEnumerable<Pair2<T>> beginWith(T start)
			{

				return this.Where(c => eq.Equals(c.first, start));// c.startWith(start));

			}

			public IEnumerable<Pair2<T>> beginWith(IEnumerable<T> starts)
			{

				return starts.SelectMany(c => beginWith(c));

			}

			public IEnumerable<Pair2<T>> endWith(T start)
			{

				return this.Where(c => eq.Equals(c.second, start));// c.endWith(start));

			}

			public IEnumerable<Pair2<T>> endWith(IEnumerable<T> starts)
			{

				return starts.SelectMany(c => endWith(c));

			}

			static public bool IsEmpty(Relation2<T> relation) {

				return relation.Count == 0;
			
			}

			static public bool IsNotEmpty(Relation2<T> relation) {
				return !IsEmpty(relation);
			
			}

			public class IsEmptyType
				:nilnul.bit.Be<Relation2<T>>
			{
				public IsEmptyType()
					:base(IsEmpty)
				{

				}

			}

			public class IsNotEmptySingleton
				:nilnul.bit.Be<Relation2<T>>
			{
				public IsNotEmptySingleton()
					:base(IsNotEmpty)
				{

				}

			}

			public class Relation___TEqTyped<TEq>
				:Relation2<T>
				where TEq:IEqualityComparer<T>,new()
			{
				static public TEq ElementEq = SingletonByDefaultNew<TEq>.Instance;
				public Relation___TEqTyped()
					:base(ElementEq)
				{

				}
				public Relation___TEqTyped(IEnumerable<Pair2<T>> pairs)
					:base(pairs,ElementEq)
				{

				}

			}

		}

		public class WithElementTyped<T>
		{
			public class WithElementEqTyped<TEq>
				where TEq:IEqualityComparer<T>,new()
			{

				public class Relation
				{


				}


			}


			
		}


	
}
