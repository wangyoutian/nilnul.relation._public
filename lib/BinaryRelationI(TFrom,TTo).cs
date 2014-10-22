using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.collection.set;

namespace nilnul.relation
{
	/// <summary>
	/// A binary relation, R, consists of a set, A, called the domain of R, a set, B, called the codomain of R, and a subset of A× Bcalled the graph of R.
	/// </summary>
	public partial interface BinaryRelationI<TFrom, TTo> : BinaryRelationI
	{
		SetI<TFrom> domain
		{
			get;
			set;

		}
		SetI<TTo> range
		{
			get;
			set;
		}
		
	}
}
