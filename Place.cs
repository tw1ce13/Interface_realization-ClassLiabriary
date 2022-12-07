using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Laba_10
{

	public class Place :  IRandomInit, IComparable, ICloneable
	{
		protected double longitude;
		protected double width;
		protected string Name;
		protected double Count;
		protected double Library_Count;

		public Place()
		{

		}


		public double SetLong
		{
			get
			{
				return longitude;
			}
			set
			{
				if ((value < 0) || (value > 180))
					longitude = Input(2);
				else
					longitude = value;
			}
		}


		public double SetWidth
		{
			get
			{
				return width;
			}
			set
			{
				if ((value < 0) || (value > 90))
					width = Input(1);
				else
					width = value;
			}
		}


		public double SetLibrary
		{
			get
			{
				return Library_Count;
			}
			set
			{
				if (value < 0)
					Library_Count = Input(5);
				else
					Library_Count = value;
			}
		}


		public string SetName
        {
            get{
				return Name;
            }
            set
            {
				Name = value;
            }
        }


		public double SetCount
        {
            get
            {
				return Count;
            }
            set
            {
				Count = value;
            }
        }


		public Place(string name, double count, double Width, double Longitude)
        {
			Name = name;
			Count = count;
			width = Width;
			longitude = Longitude;
        }


        public Place(int decision)
		{
			if (decision == 2)
			{
				Console.WriteLine("Введите название места");
				Name = Console.ReadLine();
				width = Input(1);
				longitude = Input(2);
				Count = Input(9);
			}
			else if (decision == 1)
			{
				string[] arr = new string[] { "Букингемский дворец", "Диснейленд", "Биг-Бен", "Колизей", "Памуккале", "Лувр", "Манхэттен" };
				Random rnd = new Random();
				Name = arr[rnd.Next(0, 7)];
				width = rnd.Next(1, 91);
				longitude = rnd.Next(1, 181);
				Count = rnd.Next(20, 130);
			}
		}


		public double Input(int desicion)
		{
			bool IsConverted = false;
			double value = -2;
			if (desicion == 1)
			{
				while (!IsConverted)
				{
					value = -2;
					while ((value < 0) || (value > 91))
					{
						Console.WriteLine("Границы широты = {0;90}");
						Console.WriteLine("Введите значение :");
						IsConverted = double.TryParse(Console.ReadLine(), out value);
					}
				}
			}
			else if (desicion == 2)
			{
				while (!IsConverted)
				{
					value = -2;
					while ((value < 0) || (value > 181))
					{
						Console.WriteLine("Границы долготы = {0;180}");
						Console.WriteLine("Введите значение :");
						IsConverted = double.TryParse(Console.ReadLine(), out value);
					}
				}
			}
			else if (desicion == 3)
			{
				while (!IsConverted)
				{
					value = -1;
					while (value < 0)
					{
						Console.WriteLine("Введите номер дома:");
						Console.WriteLine("Номер дома должен быть > 0");
						IsConverted = double.TryParse(Console.ReadLine(), out value);
					}
				}
			}
			else if (desicion == 4)
			{
				while (!IsConverted)
				{
					value = -1;
					while (value < 0)
					{
						Console.WriteLine("Количество людей не может быть отрицательным");
						Console.WriteLine("Введите количество людей в городе:");
						IsConverted = double.TryParse(Console.ReadLine(), out value);
					}
				}
			}
			else if (desicion == 5)
			{
				while (!IsConverted)
				{
					value = -1;
					while (value < 0)
					{
						Console.WriteLine("Количество библиотек не может быть меньше нуля");
						Console.WriteLine("Введите количество библиотек: ");
						IsConverted = double.TryParse(Console.ReadLine(), out value);
					}
				}
			}
			else if (desicion == 6)
			{
				while (!IsConverted)
				{
					value = -1;
					while (value < 0)
					{
						Console.WriteLine("Введите код города: > 0");
						IsConverted = double.TryParse(Console.ReadLine(), out value);
					}
				}
			}
			else if (desicion == 7)
			{
				while (!IsConverted)
				{
					value = -1;
					while (value < 0)
					{
						Console.WriteLine("Количество людей не может быть отрицательным");
						Console.WriteLine("Введите количество людей, проживающих по адресу:");
						IsConverted = double.TryParse(Console.ReadLine(), out value);
					}
				}
			}
			else if (desicion == 8)
			{
				while (!IsConverted)
				{
					value = -1;
					while (value < 0)
					{
						Console.WriteLine("Количество людей не может быть отрицательным");
						Console.WriteLine("Введите количество людей в мегаполисе:");
						IsConverted = double.TryParse(Console.ReadLine(), out value);
					}
				}
			}
			else if (desicion == 9)
			{
				while (!IsConverted)
				{
					value = -1;
					while (value < 0)
					{
						Console.WriteLine("Количество людей не может быть отрицательным");
						Console.WriteLine("Введите количество людей в месте:");
						IsConverted = double.TryParse(Console.ReadLine(), out value);
					}
				}
			}
			return value;
		}


		public virtual double MenCounter()
		{
			Console.WriteLine("Население мужского пола = 1");
			return 1;
		}
		

		public virtual double GirlCounter()
		{
			Console.WriteLine("Население женского пола = 1");
			return 1;
		}


		public virtual int BookCounter()
		{
			int temp = 0;
			Random rnd = new Random();
			double Library_Count = 1;
			for (int i = 0; i < Library_Count; i++)
			{
				temp += 0;
			}
			Console.WriteLine("Кол-во книг во всех библиотеках = " + temp);
			return temp;
		}


		public virtual void Print()
		{
			Console.Write("Координата широты: ");
			Console.WriteLine(width);
			Console.Write("Координата долготы: ");
			Console.WriteLine(longitude);
		}


		public override string ToString()
        {
			return "Название места " + Name + " Количество людей " + Count;
        }


		public virtual Place RandomInit()
		{
			Place temp = new Place(1);
			return temp;
        }


        public int CompareTo(object obj)
        {
            Place temp = (Place)obj;
            if (temp != null && this != null)
            {
                if (this.Count > temp.Count)
                    return 1;
                if (this.Count < temp.Count)
                    return -1;
            }
            return 0;
        }


		public Place FoundMax(Place[] array)
        {
			Place[] temp = new Place[array.Length]; 
			temp = Sort(array, 2);
			Console.WriteLine(temp[0].ToString());
			return temp[0];
        }


		public Place[] Sort(Place[] array, int decision)
		{
			Place temp;
			int compare = 0;
			switch (decision)
			{
				case 2:
					for (int i = 0; i < array.Length; i++)
					{
						for (int j = 0; j < array.Length - 1; j++)
						{
							if (array[j] != null && array[j + 1] != null)
								compare = array[j].CompareTo(array[j + 1]);
							if (compare == -1)
							{
								temp = array[j];
								array[j] = array[j + 1];
								array[j + 1] = temp;
								compare = 0;
							}
						}
					}
					break;
				case 1:
					for (int i = 0; i < array.Length; i++)
					{
						for (int j = 0; j < array.Length - 1; j++)
						{
							if (array[j] != null && array[j + 1] != null)
								compare = String.Compare(array[j].Name, array[j + 1].Name);
							if (compare == 1)
							{
								temp = array[j];
								array[j] = array[j + 1];
								array[j + 1] = temp;
							}
						}
					}
					break;
			}
			return array;
        }


		public Place BinSearch(Place[] array, int left, int right, string name)
        {
			Place temp = new Place();
			array = temp.Sort(array, 1);
			right -= 1; 
			int middle = 0;
			int compare = 0;
			while (left <= right)
            {
				middle = (left + right) / 2;
				if (array[middle] != null)
				{
					compare = String.Compare(array[middle].Name, name);
					if (compare == 0)
						return array[middle];
					else
					{
						if (compare == -1)
							left = middle + 1;
						else
							right = middle - 1;
					}
				}
				else
					right--;
			}
			return new Place();
        }


		public Place BinSearch(Place[] array, int left, int right, double count)
		{
			Place temp = new Place();
			array = temp.Sort(array, 2);
			right -= 1;
			int middle = 0;
			while (left <= right)
			{
				middle = (left + right + 1) / 2;
				if (array[middle] != null)
				{
					
					if (array[middle].Count == count)
						return array[middle];
					else
					{
						if (array[middle].Count > count)
							left = middle + 1;
						else
							right = middle - 1;
					}
				}
				else
					right--;
			}
			return new Place();
		}


		public object Clone()
        {
			return new Place("Клон " + this.Name, this.Count, this.longitude, this.width);
        }
    }
}

