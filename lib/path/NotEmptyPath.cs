using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.relation.path
{
	public partial class NotEmpty_Path<T>
		:
		nilnul.bit.be.Asserted<Path_allowEmpty_asRelation<T>,NotEmpty<T>>
	{
		public NotEmpty_Path(Path_allowEmpty_asRelation<T> path)
			:base(path)
		{


		}
	}
}
