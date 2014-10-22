using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.relation.adj
{
	public partial class Preorder
	{
		public bool Be<T>(Relation2<T> relation) {
			return Reflexive.Be(relation) && Transitive.Be(relation);
		}
	}
}
