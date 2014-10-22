using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.relation.adj
{
	/// <summary>
	/// reflexive iff for every a∈ A,aRa
	/// </summary>
	public partial class Reflexive
	{
		static public bool Be<T>(
			Relation<T> relation
			
		) {

			foreach (var item in relation)
			{
				if (
					pair.Reflexive.Not(item,relation.eq)
				)
				{
					return false;

				}
				
			}
			return true;

			throw new NotImplementedException();
		}

		static public bool Be<T>(
	Relation2<T> relation

)
		{

			foreach (var item in relation)
			{
				if (
					pair.Reflexive.Not(item, relation.eq)
				)
				{
					return false;

				}

			}
			return true;

			throw new NotImplementedException();
		}


	}
}
