using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.relation
{

	public class AntiSymmetric<T>
		: nilnul.bit.Be<Relation2<T>>
	{
		static public bool Eval(
			Relation2<T> relation
			)
		{

			foreach (var item in relation)
			{
				if (nilnul.relation.pair.Reflexive.Not(item,relation.eq))
				{
					if (relation.Contains(item.toInverse()))
					{
						return false;
						
					}
					
				}

			}

			return true;
			throw new NotImplementedException();


		}
		public AntiSymmetric()
			: base(Eval)
		{

		}

	}
}
