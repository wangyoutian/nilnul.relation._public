using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.relation
{
	public class Relation_DR<T1, T2,TEq1,TEq2>
		:Relation_DR<T1,T2>
		where TEq1:IEqualityComparer<T1>,new()
		where TEq2:IEqualityComparer<T2>,new()
	{

		public Relation_DR(

			
			
		)	:base(
			SingletonByDefaultNew<TEq1>.Instance
			,
			SingletonByDefaultNew<TEq2>.Instance
		)
		{

		}


		public Relation_DR(
			IEnumerable<Pair_DomainRange1<T1,T2>> pairs
		)
		:this()
		{
			AddRange(pairs);
		}


	




	}
}
