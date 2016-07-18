using System.Collections.Generic;
using System.Linq;

namespace OutVar {
	class Program {
		static void Main(string[] args) {
			string input = "7";

			//example 1
			if (int.TryParse(input, out var value)) {
				// value here - readonly
			} else {
				// value not in scope
			}
			// value not in scope

			//example 2
			bool test = int.TryParse(input, out var value);
			// value not in scope

			//example 3
			var strings = new List<string> { "1", "blah", "3" };
			var nums = strings.Select(item => int.TryParse(item, out var tmp) ? tmp : 0);
		}
	}
}
