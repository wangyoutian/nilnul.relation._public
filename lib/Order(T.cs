using nilnul.collection.set;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.relation
{
	public partial class Order<T>
		
	{
		static public bool Be(Relation2<T> relation) {

			return Reflexive.Be(relation) && AntiSymmetric<T>.Eval(relation) && Transitive2.Be(relation);


			throw new NotImplementedException();
		
		}

		static public bool Be(Relation2<T> relation, Set<T> set) {

			//relation.field()= set?

			throw new NotImplementedException();
		
		}

		/// <summary>
		/// t
		/// </summary>
		/// <param name="relation"></param>
		/// <returns></returns>



		static public bool Be(Set<Pair2<T>> relation)
		{
			Relation2<T> relation2 = new Relation2<T>(relation);
			return Be(relation2);


			throw new NotImplementedException();

		}
	

	}
}
