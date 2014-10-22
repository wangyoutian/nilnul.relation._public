using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.relation.path
{
	public partial class Concat<T, TEq>
		:
		nilnul.obj.op.binary.Closed<Path_allowEmpty_withStaticElementEq<T, TEq>>
		where TEq : IEqualityComparer<T>, new()
	{
		public Concat()
			:base(Eval)
		{

		}

		static public bool Concatable_loadeds(

			Path_allowEmpty_withStaticElementEq<T, TEq> a_nonEmpty
			,
			Path_allowEmpty_withStaticElementEq<T, TEq> b_nonEmpty
		)
		{
			return Concat.Concatable(a_nonEmpty, b_nonEmpty, SingletonByDefaultNew<TEq>.Instance);
		}

		static public Path_allowEmpty_withStaticElementEq<T, TEq> Eval_loadeds(
			Path_allowEmpty_withStaticElementEq<T, TEq> a_nonEmpty
			,
		 Path_allowEmpty_withStaticElementEq<T, TEq> b_nonEmpty
		)
		{
			nilnul.bit.Assert.True(Concatable_loadeds(a_nonEmpty, b_nonEmpty));
			return new Path_allowEmpty_asRelation<T, TEq>(
				Concat.Eval_nonEmpties(a_nonEmpty, b_nonEmpty,SingletonByDefaultNew<TEq>.Instance)
			);
			throw new NotImplementedException();
		}




		static public Path_allowEmpty_withStaticElementEq<T,TEq> Eval(
		 Path_allowEmpty_withStaticElementEq<T,TEq> a,
		 Path_allowEmpty_withStaticElementEq<T,TEq> b
		)
		{
			if (
				a.pairs.Count==0
			)
			{
				return new Path_allowEmpty_withStaticElementEq<T,TEq>(b.pairs);
			}
			if (b.pairs.Count==0)
			{
				return new Path_allowEmpty_withStaticElementEq<T,TEq>(a.pairs);

			}
			return Eval_loadeds(a, b);
		}

	}
}
