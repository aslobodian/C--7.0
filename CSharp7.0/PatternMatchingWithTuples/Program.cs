using System;
using System.Collections.Generic;
using static System.Console;

namespace PatternMatchingWithTuples {
	class Program {

		//C# 6.0
		Tuple<int, int> CreateSomeTuple() {
			Random r = new Random();

			return Tuple.Create(r.Next(256), r.Next(256));
		}

		//C# 7.0
		(int first, int second) CreateSomeTuple() {
			Random r = new Random();

			return (r.Next(256), r.Next(256));
		}

		static void Main(string[] args) {
			//C# 7.0
			(int sum, int count) SomeFunction(IEnumerable<int> items) {
				var r = (s: 0, c: 0);
				foreach (var item in items) {
					switch (item) {
						case int i:
							r = (r.s + i, ++r.c);
							break;
						case object[] t:
							var n = SomeFunction(t);
							r = (r.s + n.sum, r.c + n.count);
							break;
					}
				}
				return r;
			}

			var binaryNumbers = { 0b1, new object[] { 0b100, 0b1_0000 }, 0b100 };
			var result = SomeFunction(binaryNumbers);
			WriteLine($"Sum: {result.sum}, count: {result.count}");
		}
	}
}
