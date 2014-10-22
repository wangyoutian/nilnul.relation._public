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
	public partial class WarshallAlgorithm
	{
		static public void Trans(RelationMatrix m) {

			Transform(m.val);

		


		}


		static public void Trans(bool[,] m)
		{
			Trans(new RelationMatrix(m));
			

		}

		static public void Transform(bool[,] m_square)
		{
			var len = m_square.GetLength(0);


			for (int col = 0; col < len; col++)
			{
				for (int row = 0; row <len; row++)
				{
					if (m_square[row, col])
					{
						for (int k = 0; k < len; k++)
						{
							m_square[row, k] |= m_square[col, k];
							
						}
						//	RelationMatrix.AddRows(m_square, row, col);
					}

				}

			}

		}




		static void Main(string[] args)
		{
			bool[,] m = { 
						
						{false,true,false,false,false}
						
						}	;
		}




		
	}
}
