using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.tuple
{
	public partial class Square
	{
		static public bool Is<T>(T[,] matrix) {

			if (matrix.GetLength(0)!=matrix.GetLength(1))
			{
				return false;
				
			}
			return true;
		}

	}
}
