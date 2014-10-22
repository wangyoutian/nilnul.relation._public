using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.relation.adj
{
	public partial class Irreflexive
		//:
		//AntonymI<ReflexiveI,RelationI,RelationI>
	{

		
		static public bool Be<T>(
	Relation2<T> relation

	)
		{

			foreach (var item in relation)
			{
				if (pair.Reflexive.Be(item, relation.eq))
				{
					return false;

				}

			}
			return true;

		}



	

	}
}
