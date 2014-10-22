﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.element
{
	public partial class Tuple<T1,T2>:TupleI<T1,T2>
	{
		private T1 _item1;
		private T2 _item2;

		public Tuple(T1 item1,T2 item2) {
			this._item1 = item1;
			this._item2 = item2;
		}

		#region ITuple<T1,T2> Members

		public T1 item1
		{
			get
			{
				return _item1;
			}
			set
			{
				_item1 = value;
			}
		}

		public T2 item2
		{
			get
			{
				return _item2;
			}
			set
			{
				_item2=value;
			}
		}

		#endregion

		#region IList<object> Members

		public int IndexOf(object item)
		{
			throw new NotImplementedException();
		}

		public void Insert(int index, object item)
		{
			throw new NotImplementedException();
		}

		public void RemoveAt(int index)
		{
			throw new NotImplementedException();
		}

		public object this[int index]
		{
			get
			{
				throw new NotImplementedException();
			}
			set
			{
				throw new NotImplementedException();
			}
		}

		#endregion

		#region ICollection<object> Members

		public void Add(object item)
		{
			throw new NotImplementedException();
		}

		public void Clear()
		{
			throw new NotImplementedException();
		}

		public bool Contains(object item)
		{
			throw new NotImplementedException();
		}

		public void CopyTo(object[] array, int arrayIndex)
		{
			throw new NotImplementedException();
		}

		public int Count
		{
			get { throw new NotImplementedException(); }
		}

		public bool IsReadOnly
		{
			get { throw new NotImplementedException(); }
		}

		public bool Remove(object item)
		{
			throw new NotImplementedException();
		}

		#endregion

		#region IEnumerable<object> Members

		public IEnumerator<object> GetEnumerator()
		{
			throw new NotImplementedException();
		}

		#endregion

		#region IEnumerable Members

		System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			throw new NotImplementedException();
		}

		#endregion
	}
}
