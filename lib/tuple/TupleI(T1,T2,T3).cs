﻿using System;
namespace nilnul.element
{
	public partial interface TupleI<T1, T2, T3> : TupleI
	{
		T1 item1 { get; set; }
		T2 item2 { get; set; }
		T3 item3 { get; set; }
	}
}
