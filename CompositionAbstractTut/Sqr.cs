
using System;
using System.Collections.Generic;
using System.Text;

namespace CompositionAbstractTut {
	class Sqr {

		public Rect rect { get; set; }

		public int GetPerimeter() {
			return rect.GetPerimeter();
		}

		public int GetArea() {
			return rect.GetArea();
		}

		public Sqr() {

		}

		public Sqr(int s1) {
			this.rect = new Rect(s1, s1);
		}

	}
}
