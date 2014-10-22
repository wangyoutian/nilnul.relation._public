using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.relation.func
{
	public partial class InverseResult<T,TRelationByDefault>
		:RelationI2<T>
		where TRelationByDefault:RelationI2<T>,new()
	
	{


		public bool contains(T first, T second)
		{
			return !SingletonByDefaultNew<TRelationByDefault>.Instance.contains(first,second);
		}
	}
}
