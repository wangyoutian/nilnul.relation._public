using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.relation.pair
{
	public partial class Inverse<T>
		:nilnul.obj.op.unary.Closed<Pair2<T>>
	{
		static public Pair2<T> Eval(Pair2<T> pair) {
			return new Pair2<T>(pair.second, pair.first);
		
		}

		public Inverse()
			:base(Eval)
		{

		}


	}
}
