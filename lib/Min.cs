using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.math.function;
using nilnul.number.real;

namespace nilnul.function
{
	public class Min<T>:Function<T[],T>
		where T:IComparable<T>
	{
		private T[] _operands;
		public Min(params T[] operands) {
			_operands = operands;

		}
		
	}
}
