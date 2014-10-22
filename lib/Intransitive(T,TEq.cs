using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.relation
{
	/*hasse 
	Equivalently, the given graph and its transitive reduction should have the same transitive closure as each other, and its transitive reduction should have as few edges as possible among all graphs with this property.
	 */
	  
	public partial class Intransitive<T,TEq> 
		:
	nilnul.bit.Be<Relation2<T,TEq>>

		where TEq:IEqualityComparer<T>,new()

		//AntonymI<ReflexiveI,RelationI,RelationI>
	{
		static public bool Be(Relation2<T,TEq> relation) {

			var matrix = nilnul.relation.op.unary.Matrix.Eval(relation);
			var reduced = nilnul.relation.matrix.TransitiveReduceX.Eval(matrix);
			return nilnul.collection.matrix.MatrixX.Eq(matrix, reduced);

			throw new NotImplementedException();
		
		}
		public Intransitive()
			:base(Be)
		{

		}

	}
}
