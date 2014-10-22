using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.relation.op
{
	public partial class Projection
	{
		static public T Eval<T>(Tuple<T,T,T,T> tuple, uint i) {
			switch (i)
			{
				case 0:
					return tuple.Item1;
				case 1:
					return tuple.Item2;
				case 2:
					return tuple.Item3;
				case 3: 
					return tuple.Item4;
				default:
					throw new IndexOutOfRangeException();
					break;
			}
		}
	}
}
