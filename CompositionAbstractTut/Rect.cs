
using System;
using System.Collections.Generic;
using System.Text;

namespace CompositionAbstractTut {
	class Rect {

		public Quad quad { get; set; }

		public int GetPerimeter() {
			return quad.GetPerimeter();
		}

		public int GetArea() {
			return quad.Side1 * quad.Side2;
		}

		public Rect() {}

		public Rect(int s1, int s2) {
			this.quad = new Quad(s1, s2, s1, s2);
		}


	}
}
