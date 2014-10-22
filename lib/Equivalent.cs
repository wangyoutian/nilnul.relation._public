using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.relation
{
	/// <summary>
	/// Every equivalence relation is reflexive, symmetric, and transitive.
	/// </summary>
	public class Equivalent
		:nilnul.bit.Predicate<RelationI>
	{


		static private readonly Equivalent _Instance = new Equivalent();
		static public Equivalent Instance
		{
			get
			{
				return _Instance;
			}
		}
		private Equivalent()
			:base(Is_)
		{
		}

	

		static public bool Is_(RelationI relation) {
			if (relation is EquivalentRelationI)
			{
				return true;
				
			}

			
			return false;
		
		}
				

	}
}
