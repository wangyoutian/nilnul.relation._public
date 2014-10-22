using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.relation
{
	[Obsolete("see Transitive")]
	static public partial class CheckTransitiveX
	{
		static public bool Eval(RelationMatrix rm) {

			var cloned =(bool[,])( rm.val.Clone());

			var length = cloned.GetLength(0);

			for (int i = 0; i <length; i++)
			{
				for (int j = 0; j < length; j++)
				{
					if (cloned[i,j])
					{

						for (int k = 0; k < length; k++)
						{
							if ( nilnul.bit.op.binary.NotImplyX.Eval(cloned[j,k],cloned[i,k]))	//
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
