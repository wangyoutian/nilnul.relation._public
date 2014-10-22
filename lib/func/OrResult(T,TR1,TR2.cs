using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.relation.func
{
	public partial class OrResult<T,TRelationByDefault1,TRelationByDefault2>
		:RelationI2<T>
		where TRelationByDefault1:RelationI2<T>,new()
		where TRelationByDefault2:RelationI2<T>,new()
	{


		public bool contains(T first, T second)
		{
			return SingletonByDefaultNew<TRelationByDefault1>.Instance.contains(first,second) || SingletonByDefaultNew<TRelationByDefault2>.Instance.contains(first,second);
		}
	}
}
