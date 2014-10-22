using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.relation.tuple
{
	public partial class EmptyTuple<T>
	{

		static private readonly EmptyTuple<T> _Instance = new EmptyTuple<T>();
		static public EmptyTuple<T> Instance
		{
			get
			{
				return _Instance;
			}
		}
		private EmptyTuple()
		{
		}
				

	}

	public partial class EmptyTuple_multiSame<T>
	{
		public class Singleton:
			nilnul.SingletonByDefaultNew<EmptyTuple_multiSame<T>>
		{

		}

	

	}

	


}
