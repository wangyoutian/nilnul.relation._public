using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.relation.op
{
	public partial class Composite
	{

		public class WithElementTyped<T>
		{
			static public Relation<T> Eval(
				Relation<T> a,
				Relation<T> b

			)
			{

				throw new NotImplementedException();

			}

			public class WithElementEqTyped<TEq>
				where TEq : IEqualityComparer<T>, new()
			{

				static public TEq ElementEq = SingletonByDefaultNew<TEq>.Instance;

				static public Relation.Relation___elementTyped<T>.Relation___TEqTyped<TEq> Eval(
					Relation.Relation___elementTyped<T>.Relation___TEqTyped<TEq> a
					,
					Relation.Relation___elementTyped<T>.Relation___TEqTyped<TEq> b

					)
				{

					var r = new Relation.Relation___elementTyped<T>.Relation___TEqTyped<TEq>();

					foreach (var item in a)
					{
						foreach (var item2 in b)
						{
							if (ElementEq.Equals( item.second ,item2.first ))
							{
								r.add(item.first, item2.second);						
								
							}
							
						}
						
					}


					return r;


					throw new NotImplementedException();
				}

			}

		}
	}
}
