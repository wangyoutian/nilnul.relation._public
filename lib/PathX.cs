using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.relation
{
	static public partial class PathX
	{

		static public T Start<T>(IEnumerable<Pair<T>> path_countPositive)
		{


			return path_countPositive.First().first;

		}

		static public T End<T>(IEnumerable<Pair<T>> path_countPositive)
		{


			return path_countPositive.Last().second;

		}

		static public Path<T> Concat<T>(Pair<T> pair,Path<T> path) {

			return Concat(new Path<T>(new[] { pair }), path);
		
		}

		static public Path<T> Concat<T>(
			Path<T> a,
			Path<T> b
			)
		{
			if (!object.Equals(a.end(), b.start()))
			{
				throw new Exception();

			}

			var list = new List<Pair<T>>();

			list.AddRange(a.pairs);
			list.AddRange(b.pairs);

			return new Path<T>(list);



		}


		static public List<Pair<T>> Path<T>(IEnumerable<Pair<T>> relation)
		{
			if (relation == null)
			{
				return null;

			}

			var seed_countPositive = new List<Pair<T>>();


			if (relation.Count() == 0)
			{
				return seed_countPositive;

			}
			seed_countPositive.Add(relation.First());
			relation = relation.Skip(1);

			while (relation.Count() > 0)
			{

				var subsequents = relation.Where(c => object.Equals(c.first, End(seed_countPositive))).ToArray();
				if (subsequents.Count() > 1)
				{
					throw new PathForkedException();

				}

				if (subsequents.Count() == 1)
				{
					var subsequent=subsequents.First();
					seed_countPositive.Add(subsequent);
					relation=relation.Except(subsequents);


				}

				var precedents = relation.Where(c => object.Equals(c.second, Start(seed_countPositive)));
				if (precedents.Count() > 1)
				{
					throw new PathForkedException();

				}
				if (precedents.Count() == 1)
				{
					var precedent = precedents.First();

					seed_countPositive.Insert(0, precedent);
					relation = relation.Except(precedents);

				}

				if (subsequents.Count()==0 && precedents.Count()==0)
				{
					throw new Exception("not a simple path");
					
				}
			//	relation = relation.Skip(1);

			}
			//nilnul.bit.AssertionNullaryFunc.True(relation.Count() == 0);
			return seed_countPositive;

		}

		static public bool Be<TElement>(
			NotNull2<IEnumerable<TElement>> elements
			,NotNull2<RelationI2< TElement>> relation
			
		) {

			return _Be<TElement>(elements.val,relation.val);
		
		}

	

		static public  bool _Be<TElement>(
			IEnumerable<TElement> elements_notNull 
			,RelationI2<TElement> relation_notNull
		) {
			for (int i = 1; i < elements_notNull.Count(); i++)
			{
				if (!relation_notNull.contains(elements_notNull.ElementAt(i - 1), elements_notNull.ElementAt(i)))
				{
					return false;
				}
				
			}
			return true;
		

		}


	}	//class



}

