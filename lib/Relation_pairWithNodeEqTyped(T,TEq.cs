using nilnul.collection.set;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.relation
{
	public partial class Relation_pairWithNodeEqTyped<T,TEq>
		:
		Relation<T>
		//where T:IEquatable<T>
		where TEq:IEqualityComparer<T>,new()
	{
		static public TEq NodeEq = SingletonByDefaultNew<TEq>.Instance;



		public Relation_pairWithNodeEqTyped()
			:base(NodeEq)
		{

		}


		public Relation_pairWithNodeEqTyped(IEnumerable<Pair2<T>> pairs)
			:base(pairs,NodeEq)
		{
		}


	

		
	}
}
