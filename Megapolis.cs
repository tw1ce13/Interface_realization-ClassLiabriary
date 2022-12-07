using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Laba_10
{
	public class Megapolis : Place
	{

		protected double CodeofCity = 0;


		public Megapolis()
		{
			CodeofCity = 0;
		}


		public Megapolis(int decision) 
		{
			if (decision == 2)
			{
				width = Input(1);
				longitude = Input(2);
				Name = Console.ReadLine();
				Count = Input(8);
				CodeofCity = Input(6);
			}
			else if (decision == 1)
			{
				double[] arr_code = new double[] {495, 812, 383, 343, 831, 846, 843, 342};
				string[] arr = new string[] { "Москва", "Абу-Даби", "Дубаи", "Нью-Йорк", "Вашингтон", "Бразилиа", "Берлин" };
				Random rnd = new Random();
				Name = arr[rnd.Next(0, 7)];
				Count = rnd.Next(1000000, 20000000);
				CodeofCity = arr_code[rnd.Next(0, 8)];
			}
		}


		public override int BookCounter()
		{
			int temp = 0;
			Random rnd = new Random();
			double Library_Count = rnd.Next(15,40);
			for (int i = 0; i < Library_Count; i++)
			{
				temp += rnd.Next(1125, 43750);
			}
			Console.WriteLine("Кол-во книг во всех библиотеках = " + temp);
			return temp;
		}


		public override double MenCounter()
		{
			Console.WriteLine("Население мужского пола = " + Math.Round(Count * 37 / 100));
			return Math.Round(Count * 37 / 100);
		}


		public override double GirlCounter()
		{
			Console.WriteLine("Население женского пола = " + Math.Round(Count * 63 / 100));
			return Math.Round(Count * 63 / 100);
		}


		public override void Print()
		{
			base.Print();
			Console.WriteLine("Название мегаполиса: " + Name);
			Console.WriteLine("Население: " + Count);
		}


		public override Place RandomInit()
		{
			Megapolis temp = new Megapolis(1);
			return temp;
		}
	}
}


