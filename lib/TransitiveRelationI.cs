using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.relation
{
	/// <summary>
	/// an assertion that a relation is transitive. If you inherit this, it's your responsibility to guarantee it's transitive. we believe you.
	/// Or you can use the TransitiveI predicate, which can judge, for example, by Walshall Algorithm, whether the relation is transivite in your class' constructor.
	/// </summary>
	public interface TransitiveRelationI 
		:RelationAxiomizedI<TransitiveI>
		//:
		//AdjectiveI<RelationI>
	{
	}
}
