using System;

namespace BinaryLiterals {
	class Program {

		static void Main(string[] args) {

			int nineteen = 0b10011;
			Console.WriteLine(nineteen);

			int[] numbers = { 0b1, 0b10, ob100, 0b1000, 0b10000, ob100000 };
			foreach (var number in numbers) {
				Console.WriteLine(number);
			}
		}
	}
}
