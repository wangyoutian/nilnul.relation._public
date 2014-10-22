using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.relation
{
	public partial class Pair_DomainRange1<TD,TR>
	{
		public TD first;
		public TR second;


		public Pair_DomainRange1(TD first, TR second)
		{
			this.first = first;
			this.second = second;

		}



		public Pair_DomainRange<TR,TD> toInverse()
		{
			return new Pair_DomainRange<TR,TD>(second, first);
		}

		public class Eq
			:IEqualityComparer<Pair_DomainRange1<TD,TR>>
		{
			private IEqualityComparer<TD> _domainElementEq;

			public IEqualityComparer<TD> domainElementEq
			{
				get { return _domainElementEq; }
				set { _domainElementEq = value; }
			}

			private IEqualityComparer<TR> _rangeElementEq;

			public IEqualityComparer<TR> rangeElementEq
			{
				get { return _rangeElementEq; }
				set { _rangeElementEq = value; }
			}
			
			

			public Eq(IEqualityComparer<TD> domainElementEq, IEqualityComparer<TR> rangeElementEq)
			{

				this.domainElementEq = domainElementEq;
				this.rangeElementEq = rangeElementEq;

			}

			public Eq()
				:this(EqualityComparer<TD>.Default,EqualityComparer<TR>.Default)
			{

			}

			public bool Equals(Pair_DomainRange1<TD, TR> x, Pair_DomainRange1<TD, TR> y)
			{
				return domainElementEq.Equals(x.first, y.first) && rangeElementEq.Equals(x.second,y.second);

				throw new NotImplementedException();
			}

			public int GetHashCode(Pair_DomainRange1<TD, TR> obj)
			{
				return obj.first.GetHashCode() ^ obj.second.GetHashCode();

				throw new NotImplementedException();
			}
		}


		public class Eq<TDEq,TREq>
			:Eq
			where TDEq:IEqualityComparer<TD>,new()
			where TREq:IEqualityComparer<TR>,new()
		{
			public Eq()
				:base(SingletonByDefaultNew<TDEq>.Instance,SingletonByDefaultNew<TREq>.Instance)
			{

			}

		}

	
	}
}
