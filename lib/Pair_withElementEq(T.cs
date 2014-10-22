using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.relation
{
	public partial class Pair_withElementEq<T>
		:Pair2<T>
	{
		private IEqualityComparer<T> _elementEq;

		public IEqualityComparer<T> elementEq
		{
			get { return _elementEq; }
			set { _elementEq = value; }
		}


		public Pair_withElementEq(T first, T second, IEqualityComparer<T> elementEq)
			: base(first, second)
		{
			this._elementEq = elementEq;
		}
		public Pair_withElementEq(T first, T second)
			: this(first, second, EqualityComparer<T>.Default)
		{

		}

		public IEqualityComparer<Pair_withElementEq<T>> eq {
			get {
				return new Pair2<T>.Eq(_elementEq);
			}
		
		}
		

		public Pair_withElementEq<T> toInverse() {
			return new Pair_withElementEq<T>(second, first);
		}

	

	


		


		
	}
}
