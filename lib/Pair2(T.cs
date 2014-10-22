using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.relation
{
	/// <summary>
	/// with no element eq
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public partial class Pair2<T>
	{
		public T first;
		public T second;

		public Pair2(T first,T second)
		{
			this.first = first;
			this.second = second;
		}

		public Pair2<T> toInverse() {
			return new Pair2<T>(second, first);
		}

		public IEnumerable<T> nodes{
			get {
				yield return first;
				yield return second;
			}
		}
		public override string ToString()
		{
			return string.Format("[{0},{1}]",first,second);
			
		}

		public class Eq
			:
			IEqualityComparer<Pair2<T>>
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

			public Eq()
				:this(EqualityComparer<T>.Default)
			{

			}


			public bool Equals(Pair2<T> x, Pair2<T> y)
			{
				return eq.Equals(x.first, y.first) && eq.Equals(x.second, y.second);
				throw new NotImplementedException();
			}

			public int GetHashCode(Pair2<T> obj)
			{
				return eq.GetHashCode(obj.first) ^ eq.GetHashCode(obj.second);
				throw new NotImplementedException();
			}

			public bool Equals(Eq other)
			{
				return this._eq == other.eq;

				throw new NotImplementedException();
			}
		}
			

	


		


		
	}
}
