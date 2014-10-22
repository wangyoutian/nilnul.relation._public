using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.relation.path.loaded
{
	public partial class Begin
	{
		static public T Get<T>(NotEmpty_Path<T> path) {

			return path.val.First().first;

			throw new NotImplementedException();
		
		}

		static public T Get<T>(IEnumerable<Pair2<T>> path)
		{

			return path.First().first;

			throw new NotImplementedException();

		}

	}
}
