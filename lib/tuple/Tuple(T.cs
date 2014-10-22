using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.relation.tuple
{
	public partial class Tuple<T>
		:System.Tuple<T>
	{
		public Tuple(T val)
			:base(val)
		{

		}

	}
}
