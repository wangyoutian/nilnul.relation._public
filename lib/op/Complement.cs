using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.relation.op
{
	public partial class Complement<TDomain,TRange>
	{
		static public RelationI_domainRange<TDomain, TRange> Eval(
			RelationI_domainRange<TDomain,TRange> arg
			
		) {

			return new Expr(arg);
		
		}

		public class Expr
			:nilnul.obj.op.expr.ArgA<RelationI_domainRange<TDomain,TRange>>

			,

			RelationI_domainRange<TDomain	,TRange>
		{
			
			public Expr(RelationI_domainRange<TDomain,TRange> arg)
				:base(arg)
			{

			}



			public bool contains(TDomain first, TRange second)
			{

				return !arg.contains(first, second);
				throw new NotImplementedException();
			}
		}
	}
}
