using System;
using System.Collections;

namespace GenericTypes
{
	class Program
	{
		/// <summary>Заполнение переданного массива объектами Person.</summary>
		/// <param name="count">Количество добавляемых людей.</param>
		/// <param name="array">Изменяемый массив.</param>
		static void AddArrayPerson(int count, ref ArrayList array)
		{
			for(int i = 0; i < count; i++)
			{
				Console.Write("Введите имя: ");
				string name = Console.ReadLine();
				Console.Write("Введите возраст: ");
				int age = int.Parse(Console.ReadLine());
				Console.WriteLine();

				array.Add(new Person(name, age));
			}
		}

		/// <summary>Вывод массива объектов Person</summary>
		static void PrintArrayPerson(in ArrayList array)
		{
			Console.WriteLine($"Список людей:");
			foreach(Person p in array)
			{
				Console.WriteLine(p.ToString());
			}
		}

		static void Main(string[] args)
		{
			int N = 3;

			var list = new ArrayList(N);
			Console.WriteLine($"Создание списка из {N} человек:");

			AddArrayPerson(N, ref list);
			PrintArrayPerson(list);
		}
	}
}
