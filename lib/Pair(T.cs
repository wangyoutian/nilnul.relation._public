using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.relation
{
	public partial class Pair<T>
	{
		public T first;
		public T second;

		public Pair(T first,T second)
		{
			this.first = first;
			this.second = second;
		}
					

		public bool reflexive() {
			return  first.Equals(second);
		}

		public bool irreflexive() {
			return !reflexive();
		}

		public Pair<T> inverse()
		{
			return new Pair<T>(second, first);
		}
		public void inverse2()
		{
			T temp = first;
			first = second;
			second = temp;
		}

		public Pair<T> toInverse()
		{
			return new Pair<T>(second, first);
		}

		public bool startWith(T first) {
			return object.Equals( this.first ,first);
		}

		public bool endWith(T first)
		{
			return object.Equals(this.second, first);
		}

		public class Inverse:PairI<T>
			
		{
			Pair<T> _original;

			public Inverse(Pair<T> pair)
			{
				this._original = pair;
			}





			public T first
			{
				get {return _original.second; }
			}

			public T second
			{
				get { return _original.first; }
			}
		}

		

		public partial class Eq:IEqualityComparer<Pair<T>>
		{
			Func<Pair<T>, Pair<T>, bool> _func;



			public Eq(Func<Pair<T>,Pair<T>,bool> func)
			{
				this._func = func;

			}
					
			bool eval(Pair<T> a, Pair<T> b) {
				return _func(a, b);

			
			}

			public bool Equals(Pair<T> x, Pair<T> y)
			{
				return _func(x,y);
			}

			public int GetHashCode(Pair<T> obj)
			{
				return obj.first.GetHashCode() ^ obj.second.GetHashCode();
			}
		}

		public bool Equals(Pair<T> other)
		{
			return object.Equals(this.first, other.first) && object.Equals(this.second, other.second);
			//this.first.Equals( other.first) && this.second.Equals(other.second);
			
		}
	}
}
