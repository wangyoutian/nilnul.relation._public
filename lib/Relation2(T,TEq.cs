using nilnul.collection.set;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.relation
{
	public partial class Relation2<T,TEq>
		:
		Relation2<T>
		//where T:IEquatable<T>
		where TEq:IEqualityComparer<T>,new()
	{
		static public TEq NodeEq = SingletonByDefaultNew<TEq>.Instance;

		public Relation2()
			:base(NodeEq)
		{

		}


		public Relation2(IEnumerable<Pair2<T>> pairs)
			:base(pairs,NodeEq)
		{
		}


	

		
	}
}
