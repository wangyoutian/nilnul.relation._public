using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.relation
{

	[Serializable]
	public class PathForkedException : Exception
	{
		public PathForkedException() { }
		public PathForkedException(string message) : base(message) { }
		public PathForkedException(string message, Exception inner) : base(message, inner) { }
		protected PathForkedException(
		  System.Runtime.Serialization.SerializationInfo info,
		  System.Runtime.Serialization.StreamingContext context)
			: base(info, context) { }
	}

}

