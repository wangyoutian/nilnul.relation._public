using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.relation
{
	/// <summary>
	/// hasse relation is a relation that is:
	///		intransitive
	///		connected
	///		
	/// , which is an order that is intranstively reduced.
	/// </summary>
	public partial class Hasse<T>
	{
		private Relation2<T> _relation;
		public Relation2<T>	relation
		{
			get {
				return _relation;
			}
			set {

				nilnul.bit.Assert.True(
					Intransitive<T>.Be(value)	
				);


				_relation = value; 
			}
		}
		public Hasse()
		{
			_relation = new Relation2<T>();
		}
	}
}
