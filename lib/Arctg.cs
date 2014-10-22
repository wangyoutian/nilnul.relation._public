using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.math.complex.real.set;

namespace nilnul.math.complex.real.function
{
	public class Arctg:Function
	{
		static public Function Derivative(Real x) {
			Function f = new Function();
			f.logic= x => 1 / (1 + x.Power(2));
			f.domain = new Interval(Infinite.Negative,Infinite.Positive,Interval.Type.Open);
		}
	}
}
