using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.relation.adj
{
	public partial class IreflexiveOrder
	{
		static public bool Be<T>(Relation2<T> relation) {
			return ExtendedOrder.Be(relation) && Irreflexive.Be(relation);
		}
	}
}
