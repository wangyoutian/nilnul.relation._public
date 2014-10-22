using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnulTheorem.binaryRelation
{
	/// <summary>
	/// Given any total function, g, from a set, A, to a collection of sets, define the binary relation g on Aby the rule:ag b iff g(a)⊂ g(b) (6) for a,b∈ A. A binary relation, R, on a set, A, is a partial order iff there is a gsuch that Ragrees with g for every pair of distinct elements. That is,aRb iff ag b (7)for all a= b∈ A.
	/// </summary>
	class PartialOrder
	{
		
	}
	///A partial order is called weak iff it is reflexive.
	///
	/// In general,a partial order may be neither weak nor strict; this happens when some elements are related to themselves and others are not.
	///
	///A binary relation, R, on a set A, is irreflexive iff for all a∈ Ait is not true that aRa.A partial order is strict iff it is irreflexive.
}
