using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.relation.adj
{
	public class ReflexiveOrder
	{
		static public bool Be<T>(Relation2<T> relation)
		{
			return ExtendedOrder.Be(relation) && Reflexive.Be(relation);

		}

		public class Relation<T> :
			nilnul.bit.Be<Relation2<T>>
		{
			public Relation()
				: base(Be)
			{

			}

			public class Suite
				:nilnul.bit.be.assert.ed.Suite<Relation2<T>,Relation<T>>
			{
				
			}

			public class Asserted :
				nilnul.bit.be.Asserted<Relation2<T>, Relation<T>>
			{
				public Asserted(Relation2<T> r)
					: base(r)
				{
					Suite.AssertInstance.assert(r);

					


				}
			}

			public class Assert
				: nilnul.bit.be.Assert<Relation2<T>, Relation<T>>
			{

				public class Order
					: nilnul.relation.Relation2<T>
				{
					public Order(IEqualityComparer<T> elementEq)
						: base(elementEq)
					{
						Suite.Assert.Instance.assert(this);

					}

					public Order()
						: this(EqualityComparer<T>.Default)
					{

					}

					public Order(IEnumerable<Pair2<T>> pairs, IEqualityComparer<T> eq)
						: base(pairs, eq)
					{
						Suite.Assert.Instance.assert(this);

					}
					public Order(IEnumerable<Pair2<T>> pairs)
						: this(pairs,EqualityComparer<T>.Default)
					{

					}



				}


			}



		}
	}
}
