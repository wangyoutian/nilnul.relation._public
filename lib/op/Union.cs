using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.relation.op
{
	public partial class Union<TDomain,TRange>
	{

		static public RelationI_domainRange<TDomain, TRange> Eval(

			RelationI_domainRange<TDomain, TRange> arg, RelationI_domainRange<TDomain, TRange> arg1

			
		) {

			return new Expr(arg, arg1);
		
		}

		public class Expr
			:nilnul.obj.op.expr.ArgArg1A<RelationI_domainRange<TDomain,TRange>,RelationI_domainRange<TDomain,TRange>>
			,
			RelationI_domainRange<TDomain,TRange>
		{
			public Expr(RelationI_domainRange<TDomain,TRange> arg,RelationI_domainRange<TDomain,TRange> arg1)
				:base(arg,arg1)
			{

			}

			public bool contains(TDomain first, TRange second)
			{

				throw new NotImplementedException();
			}
		}
	}
}
