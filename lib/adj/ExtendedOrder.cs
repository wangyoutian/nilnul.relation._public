using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.relation.adj
{
	public class ExtendedOrder
	{
		static public bool Be<T>(Relation2<T> relation) {
 
			return Transitive.Be(relation) &&AntiSymmetric<T>.Eval(relation);
		
		}
	}
}
