using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.relation
{
	/// <summary>
	/// transitive iff for every a,b,c∈ A,[aRband bRc] implies aRc.
	/// </summary>
	public class Transitive:
		nilnul.bit.Predicate<RelationI>

		
	{

		static private readonly Transitive _Instance = new Transitive();
		static public Transitive Instance
		{
			get
			{
				return _Instance;
			}
		}
		private Transitive()
			:base(Is)
		{
		}
		static public bool Is(RelationI x) {
			if (x is TransitiveRelationI)	//the developers responsibility. here is a short cut by belief.
			{
				return true;
				
			}
			return false;

		
		}

		static public bool Is(RelationMatrix rm)
		{

			var cloned = (bool[,])(rm.val.Clone());

			var length = cloned.GetLength(0);

			for (int i = 0; i < length; i++)
			{
				for (int j = 0; j < length; j++)
				{
					if (cloned[i, j])
					{

						for (int k = 0; k < length; k++)
						{
							if (nilnul.bit.op.binary.NotImplyX.Eval(cloned[j, k], cloned[i, k]))	//
							{
								return false;
							}

						}

					}

				}

			}
			return true;


		}


				

	}
}
