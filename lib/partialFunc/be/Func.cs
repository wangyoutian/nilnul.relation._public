using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.relation.partialFunc.be
{
	public partial class Func<TDomain,TRange>

	{
		static public bool Eval(
			nilnul.relation.be.PartialFunc<TDomain,TRange>.Asserted partialFunc
			,
			nilnul.collection.set.Set_hashSet<TDomain> domain
		) {

			return domain.IsSubsetOf(partialFunc.val.getDomain());

			throw new NotImplementedException();
		
		}

		
	}
}
