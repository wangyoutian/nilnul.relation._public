using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.relation.op.unary
{
	public partial class Inverse
	{
		static public Relation.Relation___elementTyped<T> Eval<T>(
			Relation.Relation___elementTyped<T> relation

		)
		{
			var r = new Relation.Relation___elementTyped<T>(relation.eq);

			foreach (var item in relation)
			{
				r.Add(item.toInverse());

			}
			return r;

			throw new NotImplementedException();

		}
		static public Relation.Relation___elementTyped<T> Eval<T,TEq>
		(
			Relation.Relation___elementTyped<T> relation

		)
			where TEq:IEqualityComparer<T>,new()
		{
			var r = new Relation.Relation___elementTyped<T>.Relation___TEqTyped<TEq>();

			foreach (var item in relation)
			{
				r.Add(item.toInverse());

			}
			return r;

			throw new NotImplementedException();

		}
	}
}
