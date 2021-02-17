using System;

namespace CompositionAbstractTut {
	class Program {
		static void Main(string[] args) {

			/*
			var quad1 = new Quad(3, 7, 4, 5);
			Console.WriteLine($"quad1 perimeter is {quad1.GetPerimeter()}");
			Console.WriteLine($"    and area is unknown");
			Console.WriteLine($"    print is {quad1.Print()}.\n");
			*/

			var rect1 = new Rect(3, 7);
			Console.WriteLine($"rect1 perimeter is {rect1.GetPerimeter()}");
			Console.WriteLine($"  and area is {rect1.GetArea()}");
			
			var sqr1 = new Sqr(5);
			Console.WriteLine($"sqr1 perimeter is {sqr1.GetPerimeter()}");
			Console.WriteLine($"    and area is {sqr1.GetArea()}");

			/*
			Console.WriteLine($"  print is {rect1.Print()}.\n");
			*/
			/*
			Console.WriteLine($"    print is {sqr1.Print()}.\n");

			var poly = new Quad[] { sqr1, rect1, quad1 };

			foreach (var quad in poly) {
				Console.WriteLine($"Type is {quad.Print()}.");

				// needed b/c there is no GetArea() method for Quad class
				var rect = quad as Rect;
				if (rect != null) {
					Console.WriteLine($"The shape has an area of {rect.GetArea()}.\n");
				}

				*/

		}
	}
}
