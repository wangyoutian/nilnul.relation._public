using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.relation
{
	public partial class Pair_DomainRange<TD,TR>
	{
		public TD first;
		public TR second;

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

		public IEqualityComparer<Pair_DomainRange<TD, TR>> eq { get {
			return new Eq(domainElementEq, rangeElementEq);
		} }
		
		

		public Pair_DomainRange(TD first, TR second, IEqualityComparer<TD> domainElementEq,IEqualityComparer<TR> rangeElementEq)
		{
			this.first = first;
			this.second = second;
			this.domainElementEq = domainElementEq;
			this.rangeElementEq = rangeElementEq;
		}

		public Pair_DomainRange(TD first, TR second)
			:this(first,second,EqualityComparer<TD>.Default,EqualityComparer<TR>.Default)
		{

		}
					


		public Pair_DomainRange<TR,TD> toInverse()
		{
			return new Pair_DomainRange<TR,TD>(second, first);
		}

		public class Eq
			:IEqualityComparer<Pair_DomainRange<TD,TR>>
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

			public bool Equals(Pair_DomainRange<TD, TR> x, Pair_DomainRange<TD, TR> y)
			{
				return domainElementEq.Equals(x.first, y.first) && rangeElementEq.Equals(x.second,y.second);

				throw new NotImplementedException();
			}

			public int GetHashCode(Pair_DomainRange<TD, TR> obj)
			{
				return obj.first.GetHashCode() ^ obj.second.GetHashCode();

				throw new NotImplementedException();
			}
		}


		

	
	}
}
