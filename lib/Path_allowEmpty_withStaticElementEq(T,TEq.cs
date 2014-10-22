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
	/// <summary>
	/// 
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <remarks>
	/// there may be cycles.
	/// </remarks>
	public class Path_allowEmpty_withStaticElementEq<T,TEq>
		where TEq:IEqualityComparer<T>,new()
	{

		static public TEq ElementEq = SingletonByDefaultNew<TEq>.Instance;

		public class Op
		{
			static public IEnumerable<Pair_withNoEq.Pair<T>> Concat(IEnumerable<Pair_withNoEq.Pair<T>> a, IEnumerable<Pair_withNoEq.Pair<T>> b, IEqualityComparer<T> eq)
			{

				if (a.Count() == 0)
				{
					return b;

				}
				if (b.Count() == 0)
				{
					return a;

				}

				if (eq.Equals(a.Last().second, b.First().first))
				{


					var list = new List<Pair_withNoEq.Pair<T>>();

					list.AddRange(a);
					list.AddRange(b);

					return list;
					throw new NotImplementedException();

				}

				return null;


				throw new NotImplementedException();

			}

		}



		static public bool Be(
IEnumerable<Pair_withNoEq.Pair<T>> paths
,
IEqualityComparer<T> eqComparer
)
		{

			var pairEq = new Pair2<T>.Eq(eqComparer);


			//paths is not null.
			var countMinusOne = paths.Count() - 1;
			for (int i = 0; i < countMinusOne; i++)
			{
				if (!eqComparer.Equals(
					paths.ElementAt(i).first, paths.ElementAt(i + 1).second

				))
				{
					return false;

				}

			}

			return true;

		}

		public class ConvertToPath
		{

			static public List<Pair_withNoEq.Pair<T>> ToPathList(IEnumerable<Pair_withNoEq.Pair<T>> pairs, IEqualityComparer<T> eq)
			{
				//if (relation == null)
				//{
				//	return null;

				//}

				var list = new List<Pair_withNoEq.Pair<T>>();

				if (pairs.Count() == 0)
				{
					return list;

				}

				list.Add(pairs.First());
				pairs = pairs.Skip(1);

				while (pairs.Count() > 0)
				{

					var subsequents = pairs.Where(c => eq.Equals(c.first, list.Last().second)).ToArray();

					if (subsequents.Count() > 1)
					{
						throw new PathForkedException();

					}

					if (subsequents.Count() == 1)
					{
						var subsequent = subsequents.First();
						list.Add(subsequent);
						pairs = pairs.Except(subsequents);

					}

					var precedents = pairs.Where(c => eq.Equals(c.second, list.First().first));
					if (precedents.Count() > 1)
					{
						throw new PathForkedException();

					}
					if (precedents.Count() == 1)
					{
						var precedent = precedents.First();

						list.Insert(0, precedent);
						pairs = pairs.Except(precedents);

					}

					if (subsequents.Count() == 0 && precedents.Count() == 0)
					{
						throw new Exception("not a simple path");

					}
					//	relation = relation.Skip(1);

				}
				//nilnul.bit.AssertionNullaryFunc.True(relation.Count() == 0);
				return list;

			}



			[Serializable]
			public class PathForkedException : Exception
			{
				public PathForkedException() { }
				public PathForkedException(string message) : base(message) { }
				public PathForkedException(string message, Exception inner) : base(message, inner) { }
				protected PathForkedException(
				  System.Runtime.Serialization.SerializationInfo info,
				  System.Runtime.Serialization.StreamingContext context)
					: base(info, context) { }
			}




		}

		static public List<Pair2<T>> ToPathList(IEnumerable<Pair2<T>> pairs, IEqualityComparer<T> eq)
		{
			//if (relation == null)
			//{
			//	return null;

			//}

			var list = new List<Pair2<T>>();

			if (pairs.Count() == 0)
			{
				return list;

			}

			list.Add(pairs.First());
			pairs = pairs.Skip(1);

			while (pairs.Count() > 0)
			{

				var subsequents = pairs.Where(c => eq.Equals(c.first, list.Last().second)).ToArray();

				if (subsequents.Count() > 1)
				{
					throw new PathForkedException();

				}

				if (subsequents.Count() == 1)
				{
					var subsequent = subsequents.First();
					list.Add(subsequent);
					pairs = pairs.Except(subsequents);

				}

				var precedents = pairs.Where(c => eq.Equals(c.second, list.First().first));
				if (precedents.Count() > 1)
				{
					throw new PathForkedException();

				}
				if (precedents.Count() == 1)
				{
					var precedent = precedents.First();

					list.Insert(0, precedent);
					pairs = pairs.Except(precedents);

				}

				if (subsequents.Count() == 0 && precedents.Count() == 0)
				{
					throw new Exception("not a simple path");

				}
				//	relation = relation.Skip(1);

			}
			//nilnul.bit.AssertionNullaryFunc.True(relation.Count() == 0);
			return list;

		}

		#region fields

		private List<Pair2<T>> _pairs;

		#endregion

		public List<Pair2<T>> pairs
		{
			get { return _pairs; }
			set
			{

				_pairs = ToPathList(value, ElementEq);

			}
		}




		public Path_allowEmpty_withStaticElementEq(Pair2<T> pair)
			//: this(new[] { pair }, eq)
			: this(new List<Pair2<T>> { pair })
		{


		}

		public Path_allowEmpty_withStaticElementEq(
			IEnumerable<Pair2<T>> pairs
			

		)
		{
			
			_pairs = ToPathList(pairs, ElementEq);

		}

		public bool isEmpty()
		{
			return _pairs.Count == 0;
		}
		public bool isNotEmpty()
		{
			return !isEmpty();
		}

		static public bool IsEmpty(Path_allowEmpty_withStaticElementEq<T,TEq> path)
		{
			return path.pairs.Count == 0;

		}



		static public bool IsNotEmpty(Path_allowEmpty_withStaticElementEq<T,TEq> path)
		{
			return !IsEmpty(path);

		}

		public class IsEmptySingleton
			: nilnul.bit.Be<Path_allowEmpty_withStaticElementEq<T,TEq>>
		{
			public IsEmptySingleton()
				: base(IsEmpty)
			{

			}



		}
		public class IsNotEmptySingleton
			: nilnul.bit.Be<Path_allowEmpty_withStaticElementEq<T,TEq>>
		{
			public IsNotEmptySingleton()
				: base(IsNotEmpty)
			{

			}
			public class Asserted :
				nilnul.bit.be.Asserted<Path_allowEmpty_withStaticElementEq<T,TEq>, IsNotEmptySingleton>
			{

				static public T Start(Path_allowEmpty_withStaticElementEq<T,TEq> path_notEmpty)
				{
					return path_notEmpty.pairs.First().first;

				}

				static public T End(Path_allowEmpty_withStaticElementEq<T,TEq> path_notEmpty)
				{
					return path_notEmpty.pairs.Last().second;

				}

				public Asserted(Path_allowEmpty_withStaticElementEq<T,TEq> path)
					: base(path)
				{

				}

				public T start
				{
					get
					{
						return val.pairs.First().first;
					}
				}
				public T end
				{
					get
					{
						return val.pairs.Last().second;
					}
				}

				public bool isCycle()
				{
					return IsCycle(this);
				}

				static public bool IsCycle(Asserted notEmptyPath)
				{
					return ElementEq.Equals(notEmptyPath.val.pairs.First().first, notEmptyPath.val.pairs.Last().second);

				}

				public class IsCycleObj
					: nilnul.bit.Be<Asserted>
				{
					public IsCycleObj()
						: base(IsCycle)
					{

					}

					public class Asserted
						: nilnul.bit.be.Asserted<IsNotEmptySingleton.Asserted, IsCycleObj>
					{
						public Asserted(IsNotEmptySingleton.Asserted notEmptyPath)
							: base(notEmptyPath)
						{

						}



					}

				}



			}




		}



	





	}





}

