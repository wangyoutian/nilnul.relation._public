using nilnul.collection.set;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.relation
{
	public partial class SetProduct
	{
		static public Relation2<T> Eval<T>(
			Set<T> a
			,
			Set<T> b
		) {

			var r = new Relation2<T>();

			foreach (var item in a)
			{
				foreach (var item2 in b)
				{
					r.add(item, item2);
					
				}
				
			}

			return r;


			throw new NotImplementedException();
		}
	}
}
