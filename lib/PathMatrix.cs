using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.relation
{
	public partial class PathMatrix
	{
		static public void Do(bool[,] matrix) {
			var len = matrix.GetLength(0);
			for (int i = 0; i < len; i++)
			{
				for (int j = 0; j < len; j++)
				{
					if (matrix[i,j])
					{
						for (int k = 0; k < len; k++)
						{
							matrix[i, k] |= matrix[j, k];
						}
						
					}
					
				}
				
			}


			throw new NotImplementedException();
		}
	}
}
