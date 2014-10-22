using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using nilnul.collection.set;

namespace nilnul.relation
{
	public partial interface PosetI
	{
		SetI set
		{
			get;
			set;
		}

		BinaryRelationI relation
		{
			get;
			set;
		}
	}
}
