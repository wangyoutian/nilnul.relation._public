using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using nilnul.collection.set;

namespace nilnul.relation.be
{
	public partial class PartialFunc<TD,TR>
	{
		/// <summary>
		/// for every element in TD, there is at most one element in TR. It's partial or not depends whether it's total.
		/// </summary>
		/// <typeparam name="TD"></typeparam>
		/// <typeparam name="TR"></typeparam>
		/// <param name="relation"></param>
		/// <returns></returns>
		static public bool Eval(
			Relation_DR<TD,TR> relation

			
		) {

			return relation.All(
				c => nilnul.collection.set.CardinalX.Eval(
					relation.Where(x => relation.domainElementEq.Equals(x.first, c.first)).Select(y => y.second)
					, 
					relation.rangeElementEq
				)
				<
				2
			);

			throw new NotImplementedException();

		
		}

		public class Be
			:nilnul.bit.Be<Relation_DR<TD,TR>>
		{
			public Be()
				:base(Eval)
			{

			}

		}

		public class Asserted
			:nilnul.bit.be.Asserted<Relation_DR<TD,TR>,Be>
		{

			public Asserted(Relation_DR<TD,TR> r)
				:base(r)
			{

			}
			
		}
	}
}
