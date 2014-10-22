using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.relation
{
	/// <summary>
	/// definition: A relation is equivalent if it's reflexive, symmetric, and transitive.
	/// 
	/// It's an assertion that the predicate "IsEquivalent" always return true.
	/// </summary>
	/// <remarks>
	/// Its instances are axiomzied as Equivalent Relations.
	/// 
	/// </remarks>

	public partial interface EquivalentRelationI<T>
		:RelationI2<T>
		
	{

	}
}
