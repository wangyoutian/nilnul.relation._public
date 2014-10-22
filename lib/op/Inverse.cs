using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.relation.op
{
	public partial class Inverse<TDomain,TRange>

	{
		static public RelationI_domainRange<TRange, TDomain> Eval(
			RelationI_domainRange<TDomain,TRange> relation
			
		) {

			return new Expr(relation);
		
		
		}

		public class Expr:nilnul.obj.op.expr.ArgA<RelationI_domainRange<TDomain,TRange>>

			,
			RelationI_domainRange<TRange,TDomain>
		{
			public Expr(RelationI_domainRange<TDomain,TRange> arg)
				:base(arg)
			{


			}




			public bool contains(TRange first, TDomain second)
			{
				return arg.contains(second, first);

				throw new NotImplementedException();
			}
		}
	}
}
