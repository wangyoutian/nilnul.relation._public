using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.relation
{
	public partial class Path<T>
		
		:
		//Relation<T>	:note in path, there may be multiple 
		//,

		IEquatable<Path<T>>
		
	{
		List<Pair<T>> _pairs;

		public IEnumerable<Pair<T>> pairs
		{
			get
			{
				return _pairs;
			}
			set
			{
				_pairs = PathX.Path(value);
			}

		}

		public T start() {

			if (_pairs.Count()==0)
			{
				return default(T);
				
			}
			return _pairs.First().first;
		}

		public T end()
		{

			if (_pairs.Count() == 0)
			{
				return default(T);

			}
			return _pairs.Last().second;
		}

		public IEnumerable<T> nodes {

			get
			{

				foreach (var item in _pairs)
				{
					yield return item.first;

				}
				if (_pairs.Count > 0)
				{
					yield return end();

				}
			}
		}
		

	

		public Path(IEnumerable<Pair<T>> pairs)
		{
			this.pairs = pairs;
		}







		public bool Equals(Path<T> other)
		{
			if (_pairs.Count!=other._pairs.Count)
			{
				return false;
				
			}
			return nilnul.set.ListX.Equals(_pairs, other._pairs);

			throw new NotImplementedException();
		}


	}

	
		

}

