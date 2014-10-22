using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.relation
{
	/// <summary>
	/// path is a positve(non empty) string of pair, the start of each pair is the same as the end of the preceding pair.
	/// 
	/// a cycle or not
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <typeparam name="TEq"></typeparam>
	public partial class Path2<T>
	{
		public Path2(
			nilnul.bit.be.Predicated<
				IEnumerable<Pair2<T>>
				,
				nilnul.collection.enumerable.Positive<Pair2<T>>
			> edges
			,
			IEqualityComparer<T> elementEqComparer

		)
		{
			nilnul.bit.Assertion.True(Be(edges, elementEqComparer));

		}

		public Path2(
	
		IEnumerable<Pair2<T>> edges
	

)
			:this(new nilnul.bit.be.Predicated<IEnumerable<Pair2<T>>
					,
					nilnul.collection.enumerable.Positive<Pair2<T>>
				>(edges)
				,
				EqualityComparer<T>.Default
			)
		{
			

		}





		static public bool Be(

			nilnul.bit.be.Predicated<
				IEnumerable<Pair2<T>>
				,
				nilnul.collection.enumerable.Positive<Pair2<T>>
			>

			 paths

			,

			IEqualityComparer<T> eqComparer
		)
		{

			var pairEq = new Pair2<T>.Eq(eqComparer);


			//paths is not null.
			var countMinusOne = paths.val.Count() - 1;
			for (int i = 0; i < countMinusOne; i++)
			{
				if (!eqComparer.Equals(
					paths.val.ElementAt(i).first, paths.val.ElementAt(i + 1).second

				))
				{
					return false;

				}

			}

			return true;

		}




		private IEqualityComparer<T> _elementEq;

		public IEqualityComparer<T> elementEq
		{
			get { return _elementEq; }
			set { _elementEq = value; }
		}


		private nilnul.bit.be.Predicated<
				IEnumerable<Pair2<T>>
				,
				nilnul.collection.enumerable.Positive<Pair2<T>>
			> _edges;

		public nilnul.bit.be.Predicated<
				IEnumerable<Pair2<T>>
				,
				nilnul.collection.enumerable.Positive<Pair2<T>>
			>

 edges
		{
			get { return _edges; }
			set { _edges = value; }
		}


		public IEnumerable<Pair2<T>> pairsAsEnumerable
		{
			get
			{
				return edges.val;
			}
		}


		public T start()
		{


			return _edges.val.First().first;
		}

		public T end()
		{


			return _edges.val.Last().second;
		}

		public IEnumerable<T> nodes
		{

			get
			{

				foreach (var item in _edges.val)
				{
					yield return item.first;

				}

				yield return end();

			}
		}


		public class Eq : IEqualityComparer<Path2<T>>
		{

			public IEqualityComparer<T> elementEq;
			public Eq(IEqualityComparer<T> elementEq)
			{
				this.elementEq = elementEq;
				this._pairEq = new Pair2<T>.Eq(elementEq);

			}

			private IEqualityComparer<Pair2<T>> _pairEq;
			public IEqualityComparer<Pair2<T>> pairEq
			{
				get
				{
					return _pairEq;
				}
			}

			public IEqualityComparer<IEnumerable<Pair2<T>>> enumerableEqCreater()
			{
				return new nilnul.collection.enumerable.Eq<Pair2<T>>(_pairEq);
			}



			public bool Equals(Path2<T> x, Path2<T> y)
			{

				return enumerableEqCreater().Equals(x.pairsAsEnumerable, y.pairsAsEnumerable);


				throw new NotImplementedException();
			}

			public int GetHashCode(Path2<T> obj)
			{
				return 0;
				throw new NotImplementedException();
			}
		}







	}




}

