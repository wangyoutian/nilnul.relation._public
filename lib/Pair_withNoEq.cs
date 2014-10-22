using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.relation
{
	public partial class Pair_withNoEq
	{
		public class Pair<T>
		{
			#region fields
			public T first;
			public T second;

			#endregion

			public Pair(T first, T second)
			{
				this.first = first;
				this.second = second;
			}

			public Pair<T> toInverse()
			{
				return new Pair<T>(second, first);
			}

			static public bool IsReflexive(IEqualityComparer<T> eq, Pair<T> pair)
			{
				return eq.Equals(pair.first, pair.second);
			}

			public class WithElementEq
				:Pair<T>
			{
				private IEqualityComparer<T> _elementEq;

				public IEqualityComparer<T> elementEq
				{
					get { return _elementEq; }
					set { _elementEq = value; }
				}
				

				public WithElementEq(T first, T second, IEqualityComparer<T> eq)
					:base(first,second)

				{
					this._elementEq = eq;

				}

				public bool isReflexive() {

					return IsReflexive(_elementEq, this);
				}

			}

			public class Eq
				:
				IEqualityComparer<Pair_withNoEq.Pair<T>>
				,
				IEquatable<Eq>
			{
				private IEqualityComparer<T> _eq;

				public IEqualityComparer<T> eq
				{
					get { return _eq; }
					set { _eq = value; }
				}

				public Eq(IEqualityComparer<T> eq)
				{
					this._eq = eq;

				}



				public bool Equals(Pair_withNoEq.Pair<T> x, Pair_withNoEq.Pair<T> y)
				{
					return eq.Equals(x.first, y.first) && eq.Equals(x.second, y.second);
					throw new NotImplementedException();
				}

				public int GetHashCode(Pair_withNoEq.Pair<T> obj)
				{
					return eq.GetHashCode(obj.first) ^ eq.GetHashCode(obj.second);
					throw new NotImplementedException();
				}

				public bool Equals(Eq other)
				{
					return this._eq == other.eq;

					throw new NotImplementedException();
				}

				public class Eq_byTEq<TEq>
					: Eq
					where TEq : IEqualityComparer<T>, new()
				{
					public Eq_byTEq()
						: base(SingletonByDefaultNew<TEq>.Instance)
					{

					}

				}
			}

			public class Pair_ElementEq<TEq>
				: Pair<T>
				where TEq : IEqualityComparer<T>, new()
			{
				static public TEq ElementEq = SingletonByDefaultNew<TEq>.Instance;
				public Pair_ElementEq(T first, T second)
					: base(first, second)
				{

				}

				public bool reflexive()
				{
					return IsReflexive(ElementEq, this);

				}

			}


		}











	}
}
