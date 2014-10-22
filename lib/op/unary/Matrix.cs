using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.relation.op.unary
{
	public partial class Matrix
	{
		static public bool[,] Eval<T>(Relation2<T> relation) {

			var field = relation.getField();

			var fieldCount = field.Count;

			var matrix = new bool[fieldCount, fieldCount];

			for (int i = 0; i < fieldCount; i++)
			{
				for (int j = 0; j < fieldCount; j++)
				{
					matrix[i, j] = relation.contains(field.ElementAt(i), field.ElementAt(j));

				}

			}

			return matrix;



			throw new NotImplementedException();
		
		}
	}
}
