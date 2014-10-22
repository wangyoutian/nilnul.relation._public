using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.relation.op
{
	public partial class Composite<TDomain,TMiddle,TRange,TDomainEq,TMiddleEq,TRangeEq>
		where TMiddleEq:IEqualityComparer<TMiddle>,new()
		where TRangeEq:IEqualityComparer<TRange>,new()
		where TDomainEq:IEqualityComparer<TDomain>,new()

	{
		static public Expr Eval(
				Relation_DR<TDomain,TMiddle,TDomainEq,TMiddleEq> arg
				,
				Relation_DR<TMiddle, TRange, TMiddleEq,TRangeEq> arg1
			
		) {

			return new Expr(arg, arg1);
		
		
		}


		static public TRangeEq RangeEq = SingletonByDefault<TRangeEq>.Instance;

		static public TMiddleEq MiddleEq = SingletonByDefault<TMiddleEq>.Instance;
		static public TDomainEq DomainEq = SingletonByDefault<TDomainEq>.Instance;




		public class Expr
			:nilnul.obj.op.expr.ArgArg1A<
				Relation_DR<TDomain,TMiddle,TDomainEq,TMiddleEq>
				,
				Relation_DR<TMiddle, TRange, TMiddleEq,TRangeEq>
			>
			,
			RelationI_domainRange<TDomain,TRange>
		{


			public Expr(
				Relation_DR<TDomain,TMiddle,TDomainEq,TMiddleEq> arg
				,
				Relation_DR<TMiddle, TRange, TMiddleEq,TRangeEq> arg1
				
			):base(arg,arg1)
			{

			}

			public bool contains(TDomain first, TRange second)
			{
				var query =
				from a in arg
				from b in arg1
				where MiddleEq.Equals(a.second, b.first)
				select new { a.first, b.second };


				return query.Any(c=> DomainEq.Equals(first,c.first) && RangeEq.Equals(second,c.second)   );
				throw new NotImplementedException();
			}
		}
	}
}
