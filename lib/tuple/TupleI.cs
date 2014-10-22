using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.element
{

	/// <summary>
	/// The main properties that distinguish a tuple from, for example, a set are that

	////it can contain an object more than once; 
	////the objects appear in a certain order; 
	////it has finite size. 

	////Note that (1) distinguishes it from an ordered set and that (2) distinguishes it from a multiset.

	/// </summary>
	/// 
	[Obsolete("use .data.rdb.RowI")]

	
	public partial interface TupleI
		:IList<object>
	{

	}
}
