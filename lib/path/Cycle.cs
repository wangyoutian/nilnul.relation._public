using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.relation.path
{
	public partial class Cycle
	{
		static public bool Be<T>(IEnumerable<Pair2<T>> path_notEmpty, IEqualityComparer<T> eq)
		{
			return eq.Equals(nilnul.relation.path.loaded.Begin.Get(path_notEmpty), nilnul.relation.path.loaded.End.Do(path_notEmpty));


			throw new NotImplementedException();
		}
		static public bool Be<T>(NotEmpty_Path<T> path_notEmpty)
		{
			return Be(path_notEmpty.val,path_notEmpty.val.eq);


			throw new NotImplementedException();
		}

		public partial class Adj<T>
			:nilnul.bit.be.FroFunc<NotEmpty_Path<T>>
		{
			public Adj(
					
			):base(Be<T>)
			{

			}
		}

		public class Noun<T>
			:nilnul.bit.be.Asserted<NotEmpty_Path<T>,Adj<T>>
		{


		}




	}
}
