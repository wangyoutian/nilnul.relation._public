using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.relation
{
	public partial interface IntransitiveRelationI<T> 
		:
		RelationI2<T>
		,
		IrreflexiveRelationI<T>
		,
		AsymmetricRelationI<T>

		//AntonymI<ReflexiveI,RelationI,RelationI>
	{

	}
}
