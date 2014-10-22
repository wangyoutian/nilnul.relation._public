using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.relation
{
	/// <summary>
	/// definition: any x \ y, if xRy, then y!Rx
	/// 
	/// </summary>
	/// <remarks>
	/// if a relation is asymmetricI, the relation R, must gurantee that 
	/// 
	/// Asymmetric(R) is true =====R is Assymetric..
	/// 
	/// Antisymmetric(R) is true === R is antisymmetric.
	/// 
	/// From the logic of the two, we know:
	/// Asymmetric(R) implies Antisymmetric(R)
	/// 
	/// So we say if R is Asymetric, R must be antisymmetric.
	/// 
	/// If a relation is 
	/// </remarks>
	public partial class Asymmetric<T>

	{
		static public bool Eval(nilnul.relation.Relation2<T> relation)
		{
			foreach (var item in relation)
			{
				if (relation.Contains(item.toInverse()))
				{
					return false;

				}

			}
			return true;


			throw new NotImplementedException();
		}
		static public bool Be(nilnul.relation.Relation2<T> relation)
		{
			foreach (var item in relation)
			{
				if (relation.Contains(item.toInverse()))
				{
					return false;

				}

			}
			return true;


			throw new NotImplementedException();
		}
	}
}
