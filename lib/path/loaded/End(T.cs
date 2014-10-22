using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.relation.path.loaded
{
	public partial class End<T>
		:nilnul.obj.op.Unary<
			nilnul.bit.be.Rejected<Path_allowEmpty_asRelation<T>,Empty<T>>
			,
			T
		>
	{
		public End()
			:base(End.Do)
		{

		}
		

	}
}
