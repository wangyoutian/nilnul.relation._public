using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.relation.path
{
	public partial class Empty<T>
		:
		nilnul.bit.Be<Path_allowEmpty_asRelation<T>>
	{
		public Empty()
			:base(Empty.Eval<T>)
		{

		}

		public class Noun
			:nilnul.bit.be.Predicated<Path_allowEmpty_asRelation<T>,Empty<T>>
		{
			public Noun(
				Path_allowEmpty_asRelation<T> path	
			)
				:base(path)
			{

			}

			
		}




	}

	


}
