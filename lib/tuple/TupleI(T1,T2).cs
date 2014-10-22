using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.element
{
	public partial interface TupleI<T1, T2> 
		: TupleI
	{
		T1 item1
		{
			get;
			set;
		}
		T2 item2
		{
			get;
			set;
		}
	}
}
