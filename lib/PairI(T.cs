using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.relation
{
	public partial interface PairI<T>
	{
		T first
		{
			get;
		}
		T second
		{
			get;
		}
	}
}
