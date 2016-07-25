using static System.Console;

namespace RefLocalsAndRefReturn {
	class Program {

		static void Main() {
			var arr = new[] { 1, 2, 3, 4 };
			ref int Get(int[] array, int index) => ref array[index];
			ref int item = ref Get(arr, 1);
			WriteLine(item);
			item = 10;
			WriteLine(arr[1]);
			ReadLine();
		}
		// Will print
		// 2
		// 10
	}
}

