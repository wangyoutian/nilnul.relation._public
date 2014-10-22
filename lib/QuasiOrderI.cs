using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul;

namespace nilnul.relation
{
	public partial interface QuasiOrderI
		:
		BinaryRelationI
		,
		IrreflexiveI
		,
		TransitiveI

	{

	}
}
