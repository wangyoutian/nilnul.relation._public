using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.relation.pair
{
	public partial class Eq<T>
		:IEqualityComparer<Pair2<T>>
	{
		private IEqualityComparer<T> _elementEq;

		public IEqualityComparer<T> elementEq
		{
			get { return _elementEq; }
			set { _elementEq = value; }
		}

		public Eq(IEqualityComparer<T> elementEq)
		{
			this._elementEq = elementEq;

		}
		public bool Equals(Pair2<T> x, Pair2<T> y)
		{
			return elementEq.Equals(x.first, y.first) && elementEq.Equals(x.second, y.second);

			throw new NotImplementedException();
		}

		public int GetHashCode(Pair2<T> obj)
		{
			return obj.first.GetHashCode() ^ obj.second.GetHashCode();
			throw new NotImplementedException();
		}
	}
}
