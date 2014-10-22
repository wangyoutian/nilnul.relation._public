using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.relation.path
{
	public partial class SameElementEq
	{
		static public bool Eval<T>(Zero<T>.Noun_antonym pathA, Zero<T>.Noun_antonym pathB ) {

			return (pathA.val.Comparer.Equals( pathB.val.Comparer));
		}


	}
}
