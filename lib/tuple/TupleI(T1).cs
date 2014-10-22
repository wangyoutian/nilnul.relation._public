using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.element
{
	public partial interface TupleI<T> 
		: TupleI
	{
		T item
		{
			get;
			set;
		}
		
	}
}
