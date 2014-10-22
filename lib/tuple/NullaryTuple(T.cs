using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.collection.tuple
{
	public partial class NullaryTuple<T>
	{

		static private readonly NullaryTuple<T> _Instance = new NullaryTuple<T>();
		static public NullaryTuple<T> Instance
		{
			get
			{
				return _Instance;
			}
		}
		private NullaryTuple()
		{
		}
				

	}
}
