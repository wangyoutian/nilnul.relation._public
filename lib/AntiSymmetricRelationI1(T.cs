using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.relation
{
	/// <summary>
	/// for any x,y, if xRy and yRx,then x=y
	/// 
	/// </summary>
	public partial interface AntiSymmetricRelationI1<in T> 
	//	//: 
		// RelationByAdjectiveI<AntiSymmetricI>		//T:relation
		:RelationI3<T>
	{
	}
}
