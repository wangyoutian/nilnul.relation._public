using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.relation.path
{
	public partial class NotEmpty_Path_froPath<T>
		:


		nilnul.relation.Path_allowEmpty_asRelation<T>
		

	{
		static public nilnul.bit.be.Assert<Path_allowEmpty_asRelation<T>> Assertion = SingletonByDefaultNew<nilnul.bit.be.Assert< Path_allowEmpty_asRelation<T>>.Instance;


		public NotEmpty_Path_froPath(
			IEnumerable<Pair2<T>> pairs
			)
			:base(pairs)
		{


		}
	}
}
