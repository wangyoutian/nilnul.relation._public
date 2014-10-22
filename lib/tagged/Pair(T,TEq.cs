using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.relation.tagged
{
	public partial class Pair<T,TEq>
		where TEq:IEqualityComparer<T>,new()
	{

		public nilnul.relation.Pair<T,TEq> pair;
		public object tag;

	}
}
