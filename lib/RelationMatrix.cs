using nilnul.collection.matrix;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.relation
{
	public partial class RelationMatrix
	{
		/// <summary>
		/// get the relation matrix
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="relation"></param>
		/// <returns></returns>
		static public bool[,] GetRelationMatrix<T>(
			Relation<T> relation	
		) {
			//get the field.

			var field = relation.getField();

			var fieldCount=field.Count;

			var matrix=new bool[fieldCount,fieldCount];

			for (int i = 0; i < fieldCount; i++)
			{
				for (int j = 0; j < fieldCount; j++)
				{
					matrix[i,j]=relation.contains(field.ElementAt(i),field.ElementAt(j));
					
				}
				
			}

			return matrix;


			throw new NotImplementedException();
		
		}


		static public bool[,] GetRelationMatrix<T>(
	Relation2<T> relation
)
		{
			//get the field.

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



		

		/// <summary>
		/// sum of product.
		/// </summary>
		/// <param name="a_square"></param>
		/// <param name="b_square"></param>
		/// <returns></returns>
		static public bool[,] Multi_sameSizeSquare(bool[,] a_square, bool[,] b_square) {
			var size = a_square.GetLength(0);
			var r=new bool[size,size];
			for (int row = 0; row < size; row++)
			{
				for (int col = 0; col < size; col++)
				{
					var rowI = nilnul.collection.matrix.MatrixX.Row<bool>(a_square, row);
					var colJ = nilnul.collection.matrix.MatrixX.Column(b_square, col);

					r[row, col] = Multi_innerProduct_sameSize(rowI, colJ);

					
				}
				
			}
			return r;



			throw new  NotImplementedException();
		}

		static public bool[,] Subtract_sameSize(bool[,] a_square, bool[,] b_square) {

			var len = a_square.GetLength(0);
			var r = new bool[len, len];
			for (int i = 0; i < len; i++)
			{
				for (int j = 0; j < len; j++)
				{
					r[i, j] = nilnul.bit.op.binary.NotImply.Eval(a_square[i, j], b_square[i, j]);
					
				}
				
			}
			return r;

			throw new NotImplementedException();
		
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="row"></param>
		/// <param name="col"></param>
		/// <returns></returns>

		static public bool Multi_innerProduct_sameSize(IEnumerable<bool> row, IEnumerable<bool> col) {
			bool r = false;

			for (int i = 0; i < row.Count(); i++)
			{
				r= r|| row.ElementAt(i) && col.ElementAt(i);
				
			}
			return r;


			throw new NotImplementedException();
		}
		

		private bool[,] _val;

		public bool[,] val
		{
			get
			{
				return _val;
			}
			set
			{
				if (value == null)
				{
					_val = null;

					return;
				}

				if (value.GetLength(0) != value.GetLength(1))
				{
					throw new ArgumentException("It should be a square ");

				}

				this._val = value;
			}
		}



	

		public RelationMatrix(bool[,] val)
		{
			this.val = val;

		}



		public bool eq(RelationMatrix other)
		{
			return Eq(this, other);


		}


		public bool eq(bool[,] other)
		{

			return this.eq(new RelationMatrix(other));

		}


		public bool Eq(RelationMatrix a, RelationMatrix b)
		{

			return MatrixX.Eq<bool>(a._val, b._val, (c, d) => c == d);

		}

		public bool Eq(bool[,] a,bool[,] b) {

			return Eq(new RelationMatrix(a), new RelationMatrix(b));
		
		}

		public int getLength(int rank)
		{

			if (rank != 0 || rank != 1)
			{
				throw new IndexOutOfRangeException();

			}
			if (_val == null)
			{
				return 0;

			}

			return val.GetLength(rank);
		}

		/// <summary>
		/// the number of nodes. not the total number of elements.
		/// </summary>
		public int length
		{
			get
			{
				if (_val == null)
				{
					return 0;

				}
				return val.GetLength(0);
			}

		}




		public bool this[int row, int col]
		{
			get
			{
				return val[row, col];
			}
			set
			{
				val[row, col] = value;
			}
		}

		public IEnumerable<IEnumerable<bool>> getCols()
		{
			for (int i = 0; i < length; i++)
			{
				yield return getCol(i);

			}

		}

		public IEnumerable<bool> getCol(int col)
		{
			for (int row = 0; row < length; row++)
			{
				yield return val[row, col];

			}
		}

		public void addRows(int rowsAugend, int rowsAddend)
		{

			for (int i = 0; i < length; i++)
			{
				_val[rowsAugend, i] |= _val[rowsAddend, i];

			}

		}

		static public void AddRows(bool[,] matrix_square, int rowsAugend_inBound, int rowsAddend_inBound)
		{
			var len = matrix_square.GetLength(0);

			for (int i = 0; i < len; i++)
			{
				matrix_square[rowsAugend_inBound, i] |= matrix_square[rowsAddend_inBound, i];

			}

		}

		static public void RowOredByOther(bool[,] matrix_square, int rowsAugend_inBound, int rowsAddend_inBound)
		{
			var len = matrix_square.GetLength(0);

			for (int i = 0; i < len; i++)
			{
				matrix_square[rowsAugend_inBound, i] |= matrix_square[rowsAddend_inBound, i];

			}

		}


		static public bool IsOrNot(bool[,] m)
		{

			if (m == null)
			{
				return true;

			}
			if (m.GetLength(0) != m.GetLength(1))
			{
				return false;

			}
			return true;

		}


		static public void Assert(bool[,] m)
		{

			if (m == null)
			{
				return;

			}
			if (m.GetLength(0) != m.GetLength(1))
			{
				throw new Exception("Should be square.");

			}

		}

		public override string ToString()
		{
			return MatrixX.ToString_(_val);
		}

		static public RelationMatrix Clone(RelationMatrix matrix) {
			//matrix.val.Clone();
			return new RelationMatrix((bool[,]) (matrix.val.Clone()));
		
		}





	}
}
