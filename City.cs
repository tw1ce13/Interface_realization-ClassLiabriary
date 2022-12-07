using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Laba_10
{
    public class City : Place
    {
        protected double CodeofCity = 0;

        public City()
        {
            CodeofCity = 0;
        }


        public double SetCode
        {
            get
            {
                return CodeofCity;
            }
            set
            {
                if (value < 0 && value > 100)
                {
                    value = Input(6);
                }
                else
                    CodeofCity = value;
            }
        }


        public City(int desicion) 
        {
            if (desicion == 2)
            {
                width = Input(1);
                longitude = Input(2);
                Console.WriteLine("Введите название города: ");
                Name = Console.ReadLine();
                Count = Input(4);
                CodeofCity = Input(6);
            }
            else if (desicion == 1)
            {
                string[] arr = new string[] { "Пермь", "Казань", "Лиссабон", "Париж", "Рим", "Лос-Анджелес", "Рио-Де-Жанейро" };
                Random rnd = new Random();
                Name = arr[rnd.Next(0, 7)];
                Count = rnd.Next(0, 7000000);
                CodeofCity = rnd.Next(101, 965);
            }
        }


        public override int BookCounter()
        {
            int temp = 0;
            Random rnd = new Random();
            double Library_Count = rnd.Next(8,20);
            for (int i = 0; i < Library_Count; i++)
            {
                temp += rnd.Next(970, 3750);
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


        public static City operator +(City city1, City city2)
        {
            City temp = new City();
            temp.Count = city1.Count + city2.Count;
            return temp;
        }


        public void Show_People()
        {
            Console.Write("Население: ");
            Console.WriteLine(Count);
        }


        public override void Print()
        {
            base.Print();
            Console.Write("Название города: ");
            Console.WriteLine(Name);
            Console.Write("Количество жителей в городе = ");
            Console.WriteLine(Count);

        }


        public override Place RandomInit()
        {
            City temp = new City(1);
            return temp;
        }
    }
}


