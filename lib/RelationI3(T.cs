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
	public partial interface RelationI3<in T>
		
		:ContainsI<T>

	{

		IEqualityComparer<T> elementEq
		{
			get;
		}





	}
}
