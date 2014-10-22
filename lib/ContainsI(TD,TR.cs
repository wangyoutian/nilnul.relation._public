using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.relation
{
	public partial interface ContainsI<in TD,in TR>
	{

		bool contains(TD arg, TR arg1);
	}
}
