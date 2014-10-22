using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.relation
{
	/// <summary>
	/// a cycle or not
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <typeparam name="TEq"></typeparam>
	public partial class Path2<T, TEq>
		:Path2<T>
		where TEq : IEqualityComparer<T>, new()
	{
		static public TEq elementEqComparer = SingletonByDefaultNew<TEq>.Instance;

		public Path2(nilnul.bit.be.Predicated<
				IEnumerable<Pair2<T>>
				,
				nilnul.collection.enumerable.Positive<Pair2<T>>
			> edges
		)
			:base(edges,SingletonByDefaultNew<TEq>.Instance)
		{

		}


	}




}

