using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.relation
{
	/// <summary>
	/// Get the transitive closure of a relation matrix.
	/// </summary>
	public partial class RelationMatrixToTransitiveClosureByWarshallAlgorithm
	{
		static public void Trans(RelationMatrix m) {

			for (int col = 0; col < m.length; col++)
			{
				for (int row = 0; row < m.length; row++)
				{
					if (m.val[row,col])
					{
						//
						m.addRows(row, col);

						
					}
					
				}
				
			}


		}


		static public void Trans(bool[,] m)
		{
			Trans(new RelationMatrix(m));
			

		}

		static void Main(string[] args)
		{
			bool[,] m = { 
						
						{false,true,false,false,false}
						
						}	;
		}




		
	}
}
