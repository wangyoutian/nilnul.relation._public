using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.relation.path.loaded
{
	public partial class End
	{
		static public T Do<T>(

			nilnul.bit.be.Rejected<Path_allowEmpty_asRelation<T>,Empty<T>> notEmpty
			
		) {
			return notEmpty.val.Last().second;

			throw new NotImplementedException();

		
		}


		static public T Do<T>(
			IEnumerable<Pair2<T>> pairs_notEmtpy
		)
		{
			return pairs_notEmtpy.Last().second;

			throw new NotImplementedException();


		}



	}
}
