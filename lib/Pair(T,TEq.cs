using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.relation
{
	public partial class Pair<T,TEq>
		where TEq:IEqualityComparer<T>,new()		
	{
		static public TEq EqInstance = SingletonByDefault<TEq>.Instance;

		public T first;
		public T second;

		public Pair(T first,T second)
		{
			this.first = first;
			this.second = second;
		}

		public bool reflexive() {
			return EqInstance.Equals(first,second);
		}

		public bool irreflexive() {
			return !reflexive();
		}

		public void inverse() {
			nilnul.obj.SwapX.Swap(ref first,ref second);

		}

		public Pair<T,TEq> toInverse()
		{
			return new Pair<T,TEq>(second, first);
		}

		public bool startWith(T first) {
			return EqInstance.Equals( this.first ,first);
		}

		public bool endWith(T first)
		{
			return EqInstance.Equals(this.second, first);
		}


		public partial class Eq
			:
			IEqualityComparer<Pair<T,TEq>>
		{
			



		

			public bool Equals(Pair<T,TEq> x, Pair<T,TEq> y)
			{
				return EqInstance.Equals(x.first,y.first) && EqInstance.Equals(x.second,y.second);
			}

			public int GetHashCode(Pair<T,TEq> obj)
			{
				return obj.first.GetHashCode() ^ obj.second.GetHashCode();
			}
		}

	
	}
}
