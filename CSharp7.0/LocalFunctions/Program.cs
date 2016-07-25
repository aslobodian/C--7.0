using System.Collections.Generic;
using static System.Console;

namespace LocalFunctions {
	class Program {
		static void Main(string[] args) {

			int GetLastNumber(IEnumerable <int> items){
				return items.Last();
			}

			var numbers = new List<int> { 9, 1, -23, 1993 };
			var last = GetLastNumber(numbers);
			WriteLine($"Last: {last}");
		}
	}
}
