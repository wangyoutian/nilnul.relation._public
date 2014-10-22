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
	public partial interface RelationI<T,TEq>
		
		//where T:IEquatable<T>
	{
		bool contains(T first,T second);



	}
}
