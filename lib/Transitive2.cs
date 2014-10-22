using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.relation
{
	 public partial class Transitive2
	{

		 static public bool Be<T>(Relation<T> relation)
		 {

			 var matrix = RelationMatrix.GetRelationMatrix(relation);
			 return Be(matrix);

			 throw new NotImplementedException();

		 }
		 static public bool Be<T>(Relation2<T> relation)
		 {

			 var matrix = RelationMatrix.GetRelationMatrix(relation);
			 return Be(matrix);

			 throw new NotImplementedException();

		 }


		 static public bool Be(bool[,] _relationMatrix) {

			 var length = _relationMatrix.GetLength(0);

			 for (int row = 0; row < length; row++)
			 {
				 for (int col = 0; col < length; col++)
				 {
					 if (_relationMatrix[row, col])
					 {

						 //check the rows[col]

						 for (int k = 0; k < length; k++)
						 {
							 if (nilnul.bit.op.binary.NotImplyX.Eval(_relationMatrix[col, k], _relationMatrix[row, k]))	//
							 {
								 return false;
							 }

						 }

					 }

				 }

			 }
			 return true;
		

		 
		 
		 }

		 static public bool _rowImplyRow(ref bool[,] _relationMatrix, ref int row0, ref int row1) {

			 for (int i = 0; i < _relationMatrix.GetLength(1); i++)
			 {
				if (nilnul.bit.op.binary.NotImplyX.Eval(
					_relationMatrix[row0,i]
		 			,
					_relationMatrix[row1,i]
				))
				 {
					 return false;


				 }
				 
			 }
			 return true;


			 throw new NotImplementedException();
		 
		 } 


		 static public bool Be_bitOpOnRows(bool[,] _relationMatrix)
		 {
			 var length = _relationMatrix.GetLength(0);
			 for (int row = 0; row < length; row++)
			 {
				 for (int col = 0; col < length; col++)
				 {
					if (
						nilnul.bit.op.binary.NonImply.Eval(
							_relationMatrix[row,col]
 							,
							_rowImplyRow(
								ref _relationMatrix
								,
								ref col
								,
								ref row
							)
						)
					)
					 {
						 return false;
					 }
				 }
			 }
			 return true;
		 }

		static public bool Be(RelationMatrix rm) {

			return Be(rm.val);

		
		
		}
	}
}
