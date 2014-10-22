using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.relation
{
	public partial class Pair_withStaticElementEq<T,TEq>
		:Pair2<T>
	
		where TEq:IEqualityComparer<T>,new()		
	{
		static public TEq ElementEqInstance = SingletonByDefault<TEq>.Instance;



		public Pair_withStaticElementEq(T first,T second)
			:base(first,second)
		{
			this.first = first;
			this.second = second;
		}

		public bool reflexive() {
			return ElementEqInstance.Equals(first,second);
		}

		public bool irreflexive() {
			return !reflexive();
		}

		public void inverse() {
			nilnul.obj.SwapX.Swap(ref first,ref second);

		}

		public Pair_withStaticElementEq<T,TEq> toInverse()
		{
			return new Pair_withStaticElementEq<T,TEq>(second, first);
		}

		public bool startWith(T first) {
			return ElementEqInstance.Equals( this.first ,first);
		}

		public bool endWith(T first)
		{
			return ElementEqInstance.Equals(this.second, first);
		}


		public partial class Eq
			:
			Pair2<T>.Eq
			,IEqualityComparer<Pair_withStaticElementEq<T,TEq>>
		{

			public Eq()
				:base(ElementEqInstance)
			{

			}



			public bool Equals(Pair_withStaticElementEq<T, TEq> x, Pair_withStaticElementEq<T, TEq> y)
			{
				return base.Equals(x, y);
				throw new NotImplementedException();
			}

			public int GetHashCode(Pair_withStaticElementEq<T, TEq> obj)
			{
				return base.GetHashCode(obj);
				throw new NotImplementedException();
			}
		}

	
	}
}
