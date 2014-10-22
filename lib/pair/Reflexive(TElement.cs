using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.relation.pair
{
	public class Reflexive<T>
		:nilnul.bit.BeI<Pair2<T>>
		
	{
		static public bool Be(
			Pair2<T> pair
			,
			IEqualityComparer<T> eq
		) {
			return eq.Equals(pair.first, pair.second);
		}

		private IEqualityComparer<T> _elementEq;

		public IEqualityComparer<T> elementEq
		{
			get { return _elementEq; }
			set { _elementEq = value; }
		}
		
		public Reflexive(IEqualityComparer<T> eq)
		{
			this.elementEq = eq;
		}

		public bool be(Pair2<T> obj)
		{
			return Be(obj, _elementEq);
			throw new NotImplementedException();
		}
	}
}
