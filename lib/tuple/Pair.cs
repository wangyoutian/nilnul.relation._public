﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.relation.tuple
{
	public partial class Pair<T1,T2>:OrderedPair<T1,T2>
	{

		public Pair(T1 item1,T2 item2)
			:base(item1,item2)
		{
		}
					
	}
}
