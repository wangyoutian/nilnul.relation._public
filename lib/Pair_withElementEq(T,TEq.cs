using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.relation
{
	public partial class Pair_withElementEq<T,TElementEq>
		:Pair_withElementEq<T>
		where TElementEq:IEqualityComparer<T>,new()		
	{
		static public TElementEq ElementEqInstance = SingletonByDefault<TElementEq>.Instance;

		public Pair_withElementEq(T first,T second)
			:base(first,second,ElementEqInstance)
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

		public Pair_withElementEq<T,TElementEq> toInverse()
		{
			return new Pair_withElementEq<T,TElementEq>(second, first);
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
		{

			public Eq()
				:base(ElementEqInstance)
			{

			}

		
		}

		static public Eq Eq_ofPair = SingletonByDefaultNew<Eq>.Instance;

	
	}
}
