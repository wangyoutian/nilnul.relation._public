using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.relation.path
{
	public partial class Concat
	{

		
		static public IEnumerable<Pair2<T>> Do<T>(Pair2<T> pair, IEnumerable<Pair2<T>> path, IEqualityComparer<T> elementEq)
			
		{
			return Eval(new[] { pair }, path, elementEq);

			throw new NotImplementedException();


		}
		static public bool Concatable<T>(
			IEnumerable<Pair2<T>> a_nonEmpty
			,
			IEnumerable<Pair2<T>> b_nonEmpty
			,
			IEqualityComparer<T> elementEq
		)
		{
			return elementEq.Equals(a_nonEmpty.Last().second, b_nonEmpty.First().first);
		}

		static public IEnumerable<Pair2<T>> Eval_nonEmpties<T>(
			IEnumerable<Pair2<T>> first_path_noEmpty
			,
			IEnumerable<Pair2<T>> second_path_nonEmpty
			,

			IEqualityComparer<T> eq

		)
		{
			nilnul.bit.Assert.Eval(Concatable(first_path_noEmpty, second_path_nonEmpty, eq));

			var list = new List<Pair2<T>>();

			list.AddRange(first_path_noEmpty);
			list.AddRange(second_path_nonEmpty);

			return list;


			throw new NotImplementedException();

		}

		static public IEnumerable<Pair2<T>> Eval<T>(

			IEnumerable<Pair2<T>> first_path
			,
			IEnumerable<Pair2<T>> second_path
			,

			IEqualityComparer<T> eq



			)
		{

			if (

				(first_path.Count()==0)



			)
			{
				return new List<Pair2<T>>(second_path);

			}

			if (second_path.Count()==0)
			{
				return new List<Pair2<T>>(first_path);

			}

			return Eval_nonEmpties(first_path, second_path, eq);

			throw new Exception();






		}

	}
}
