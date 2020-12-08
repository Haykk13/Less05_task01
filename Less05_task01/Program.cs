using System;

namespace Less05_task01
{
	class Program
	{
		static void Main(string[] args)
		{
			MyClass[] array = { new MyClass(), new MyClass(), new MyClass() };
			for (int i = 0; i < array.GetLength(0); i++)
			{
				array[i].Method1();
				array[i].Method2();
			}

			IInterface[] BaseArray = array;
			for (int i = 0; i < BaseArray.GetLength(0); i++)
			{
				BaseArray[i].Method1();
			}

			MyClass[] DerArray = (MyClass[])BaseArray;
			for (int i = 0; i < DerArray.GetLength(0); i++)
			{
				DerArray[i].Method1();
				DerArray[i].Method2();
			}

			Console.ReadKey();
		}
	}

	interface IInterface
	{
		void Method1();
	}

	class MyClass : IInterface
	{
		public void Method1()
		{
			Console.WriteLine("Method from Base");
		}

		public void Method2()
		{
			Console.WriteLine("Method from Derived");
		}
	}
}