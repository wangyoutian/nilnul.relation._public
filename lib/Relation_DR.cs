using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.relation
{
	public class Relation_DR<T1, T2>
		: nilnul.collection.set.Set_hashSet<Pair_DomainRange1<T1, T2>>
	{





		private IEqualityComparer<T1> _domainElementEq;

		public IEqualityComparer<T1> domainElementEq
		{
			get { return _domainElementEq; }
			private set
			{

				_domainElementEq = value;





			}
		}
		private IEqualityComparer<T2> _rangeElementEq;

		public IEqualityComparer<T2> rangeElementEq
		{
			get { return _rangeElementEq; }
			private set
			{
				_rangeElementEq = value;


			}
		}

		public HashSet<T1> getDomain()
		{

			var set = new HashSet<T1>(domainElementEq);


			this.Select(c => c.first).ForEach((d) => set.Add(d));
			return set;

		}

		public HashSet<T2> getRange()
		{

			var set = new HashSet<T2>(rangeElementEq);


			this.Select(c => c.second).ForEach((d) => set.Add(d));
			return set;

		}






		public Relation_DR(

			IEqualityComparer<T1> domainElementEq
			,
			IEqualityComparer<T2> rangeElementEq

			)
			: base(new Pair_DomainRange1<T1, T2>.Eq(domainElementEq, rangeElementEq))
		{

		}










	}
}
