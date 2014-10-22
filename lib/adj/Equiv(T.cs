using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.relation.adj
{
	public partial class Equiv<T>
	{
		static public bool Be(Relation2<T> relation) {
			return Reflexive.Be(relation) &&Symmetric.Be(relation)&&Transitive.Be(relation);

			throw new NotImplementedException();
		
		}
	}
}
