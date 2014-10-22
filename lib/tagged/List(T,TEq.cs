using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.relation.tagged
{
	public partial class List<T,TEq>
		:List<Pair<T>>
		where TEq:IEqualityComparer<T>,new()
	{



	}
}
