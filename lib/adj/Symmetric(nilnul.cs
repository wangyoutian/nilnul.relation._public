using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.relation.adj
{
	/// <summary>
	/// symmetric iff for every a,a0 ∈ A,aRa0 implies a0 Ra,
	/// </summary>
	public partial class Symmetric
		
	{
		static public bool Be<T>(
			Relation<T> relation	
		) {
			foreach (var item in relation)
			{
				if (!relation.Contains(item.toInverse()))
				{
					return false;
					
				}
				
			}
			return true;


			throw new NotImplementedException();
		}

		static public bool Be<T>(
	Relation2<T> relation
)
		{
			foreach (var item in relation)
			{
				if (!relation.Contains(item.toInverse()))
				{
					return false;

				}

			}
			return true;


			throw new NotImplementedException();
		}

		public class ElementTyped<T>
			:nilnul.bit.Be<Relation<T>>
		{
			static public bool Be(
	Relation<T> relation
)
			{
				foreach (var item in relation)
				{
					if (!relation.Contains(item.toInverse()))
					{
						return false;

					}

				}
				return true;


				throw new NotImplementedException();
			}

			public ElementTyped()
				:base(Be)
			{

			}


			
		}

	}	//class ElementTyped<T>
}
