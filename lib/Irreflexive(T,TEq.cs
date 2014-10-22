using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.relation
{
	public partial class Irreflexive<T,TEq>
		:nilnul.bit.be.FroFunc<Relation<T,TEq>>
		where TEq:IEqualityComparer<T>,new()
		//:
		//AntonymI<ReflexiveI,RelationI,RelationI>
	{
		static public TEq Eq = SingletonByDefaultNew<TEq>.Instance;

		static public bool Be(
			Relation<T,TEq> relation
			
			) {

				foreach (var item in relation)
				{
					if (item.reflexive())
					{
						return false;
						
					}
					
				}
				return true;
		
		}


		public Irreflexive()
			:base(Be)
		{

		}

	}
}
