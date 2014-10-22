using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.collection.set.relation
{
	public partial class Pair
	{
		private object  _left;

		public object  left
		{
			get { return _left; }
			set { _left = value; }
		}

		private object _right;

		public object right
		{
			get { return _right; }
			set { _right = value; }
		}


		public Pair(object left, object right)
			
		{
			this.left = left;
			this.right = right;
		}

		static public bool operator ==(Pair a,Pair b){
			return a.left==b.left && a.right==b.right;
		}

		static public bool operator !=(Pair a, Pair b){
			return !(a==b);
		}
					
		

		static public SetI ToSet<T1,T2>(T1 a,T2 b) {
			var r = new Set();

			var first = new Set();
			first.Add(a);

			var second = new set.Set();
			second.Add(a);

			second.Add(b);

			r.Add(first);
			r.Add(second);
			return r;
		}
	}
}
