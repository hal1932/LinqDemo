using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
namespace LinqDemo
{
	internal class Program
	{
		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			public static readonly Program.<>c <>9 = new Program.<>c();
			public static Func<int, int> <>9__0_0;
			internal int <Main>b__0_0(int item)
			{
				return item;
			}
		}
		private static void Main(string[] args)
		{
			Test test = new Test();
			using (IEnumerator<int> enumerator = test.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					Console.WriteLine(enumerator.Current);
				}
			}
			using (IEnumerator<int> enumerator = test.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					Console.WriteLine(enumerator.Current);
				}
			}
			Console.WriteLine(test.Count<int>());
			int[] array = test.ToArray<int>();
			int[] array2 = array;
			for (int i = 0; i < array2.Length; i++)
			{
				Console.WriteLine(array2[i]);
			}
			array2 = array;
			for (int i = 0; i < array2.Length; i++)
			{
				Console.WriteLine(array2[i]);
			}
			Console.WriteLine(array.Length);
			IEnumerable<int> arg_CA_0 = test;
			Func<int, int> arg_CA_1;
			if ((arg_CA_1 = Program.<>c.<>9__0_0) == null)
			{
				arg_CA_1 = (Program.<>c.<>9__0_0 = new Func<int, int>(Program.<>c.<>9.<Main>b__0_0));
			}
			using (IEnumerator<int> enumerator = arg_CA_0.Select(arg_CA_1).GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					Console.WriteLine(enumerator.Current);
				}
			}
			Console.Read();
		}
	}
}
