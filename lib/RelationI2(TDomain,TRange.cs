using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.relation
{
	/// <summary>
	/// finite relation
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public partial interface RelationI2<in TDomain, in TRange>
		
		//IEnumerable<Pair<T>>
		//where T:IEquatable<T>


	{


		IEqualityComparer<TDomain> domainEq
		{
			get;
		}

		IEqualityComparer<TRange> rangeEq
		{
			get;
		}

		bool contains(TDomain first,TRange second);



	}
}
