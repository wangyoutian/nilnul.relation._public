using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.relation.path
{
	public partial class Zero<T>
		:nilnul.bit.be.FroFunc<Path_allowEmpty_asRelation<T>>
		,
		nilnul.bit.BeI< Path_allowEmpty_asRelation<T>>
	{
		static public bool Eval(Path_allowEmpty_asRelation<T> path) {

			return path.Count == 0;
		
		}

		public Zero()
			:base(Eval)
		{

		}


		public class Antonym 
			:nilnul.bit.predicate.FroAntonym<Path_allowEmpty_asRelation<T>,Zero<T>>
		{ 

		
		}

		public class Noun
			:nilnul.bit.be.Predicated<Path_allowEmpty_asRelation<T>,Zero<T>>
		{
			public Noun(
				Path_allowEmpty_asRelation<T> path	
			)
				:base(path)
			{

			}

			
		}

		public class Noun_antonym 
			:nilnul.bit.BeAsserted<Path_allowEmpty_asRelation<T>, Antonym>
		{

			static public T End(
				IEnumerable<Pair2<T>> path_noEmptyPath	
			) {
				return path_noEmptyPath.Last().second;
			}
			public Noun_antonym(
				Path_allowEmpty_asRelation<T> path
				
			)
				:base(path)
			{

			}
		
		}


	}

	


}
