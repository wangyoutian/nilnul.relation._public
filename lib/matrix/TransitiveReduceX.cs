using nilnul.relation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.relation.matrix
{
	public partial class TransitiveReduceX
	{
		static public IEnumerable<Pair2<T>> Do<T>(IEnumerable<Pair2<T>> pairs, IEqualityComparer<T> eq) {
			//first 



			throw new NotImplementedException();
		
		}

		/// <summary>
		/// 
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="relationMatrix_dag">
		/// not null, square, dag(no reflexive cycles)
		/// </param>
		/// <returns></returns>\
		/// <remarks>
		/// 
		/// </remarks>
		static public void Op<T>(bool[,] relationMatrix_dag)
		{
			//first transitive closure

			nilnul.relation.TransitiveClosureX.Op_warshall(relationMatrix_dag);

			//delete cycles

			var len = relationMatrix_dag.GetLength(0);

			for (int col = 0; col < len; col++)
			{ 
				for (int row = 0; row < len; row++)
				{
					if (relationMatrix_dag[row,col])
					{
						for (int k = 0; k < len; k++)
						{
							if (relationMatrix_dag[col,k])
							{
								relationMatrix_dag[row, k] = false;
							}
							
						}
						
					}
					
				}
				
			}





			throw new NotImplementedException();

		}
		static public bool[,] Eval(bool[,] relationMatrix_dag)
		{
			//first transitive closure

			var pathMatrix = nilnul.relation.TransitiveClosureX.Eval_warshall(relationMatrix_dag);


			//delete cycles

			var len = relationMatrix_dag.GetLength(0);

			for (int col = 0; col < len; col++)
			{
				for (int row = 0; row < len; row++)
				{
					if (pathMatrix[row, col])
					{
						for (int k = 0; k < len; k++)
						{
							if (pathMatrix[col, k])
							{
								pathMatrix[row, k] = false;
							}

						}

					}

				}

			}
			return pathMatrix;




			throw new NotImplementedException();

		}

		static public bool[,] Eval_matrixOperations(bool[,] relationMatrix_dag) {
			return 	RelationMatrix.Subtract_sameSize(
				relationMatrix_dag,
				RelationMatrix.Multi_sameSizeSquare(
					relationMatrix_dag,
					TransitiveClosureX.Eval_warshall(relationMatrix_dag)
				)
			)
			;


			throw new NotImplementedException();
		
		}
	}
}
