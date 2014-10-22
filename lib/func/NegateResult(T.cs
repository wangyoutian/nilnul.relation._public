using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.relation.func
{
	public class NegateResult<T>
		:RelationI2<T>
		
	{
		private RelationI2<T> _relation;

		public RelationI2<T> relation
		{
			get { return _relation; }
			set { _relation = value; }
		}


		public NegateResult(RelationI2<T> relation)
		{
			this.relation = relation;
		}
					


		public bool contains(T first, T second)
		{
			return !relation.contains(first,second);
		}

		static public NegateResult<T> Create(RelationI2<T> relation) {
			return new NegateResult<T>(relation);
		}


	}
}
