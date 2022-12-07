using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Laba_10
{
	public class Address : City
	{
		protected string StreetName;
		protected double NumbHome;

		public Address()
		{

		}


		public Address(int desicion) : base(desicion)
		{
			if (desicion == 2)
			{

				Console.WriteLine("Введите название улицы: ");
				StreetName = Console.ReadLine();
				NumbHome = Input(3);
				Count = Input(7);
			}
			else if (desicion == 1)
			{
				string[] arr = new string[] {"Мира", "Ленина", "Попова", "Бейкерстрит", "Пушкина"}; 
				Random rnd = new Random();
				StreetName = arr[rnd.Next(0,5)];
				NumbHome = rnd.Next(0, 90);
				Count = rnd.Next(5, 25);
			}
		}


		public string SetStreet
		{
			get
			{
				return StreetName;
			}
			set
			{
				StreetName = value;
			}
		}


		public double SetNumb
		{
			get
			{
				return NumbHome;
			}
			set
			{
				if (value < 0)
					NumbHome = Input(3);
				else
					NumbHome = value;
			}
		}


		public override int BookCounter()
		{
			int temp = 0;
			Random rnd = new Random();
			double Library_Count = rnd.Next(1,3);
			for (int i = 0; i < Library_Count; i++)
			{
				temp += rnd.Next(10, 800);
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
			Console.Write("Улица " + StreetName);
			Console.WriteLine("  д. " + NumbHome);
		}


		public override Place RandomInit()
		{
			Address temp = new Address(1);
			return temp;
		}


        public override string ToString()
        {
            return base.ToString() + " Адрес " + StreetName +" "+ NumbHome;
        }
    }
}


