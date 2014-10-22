using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.relation
{
	/// <summary>
	/// subset-inclusion is only a partial order, as opposed to the total orders given before
	/// </summary>
	public interface PartialOrderI 
		:
		RelationByAdjectiveI< ReflexiveI>
		, 
		RelationByAdjectiveI< TransitiveI>
		,
		RelationByAdjectiveI<AntiSymmetricI>
		,
		BinaryRelationI
	{

	}
}
