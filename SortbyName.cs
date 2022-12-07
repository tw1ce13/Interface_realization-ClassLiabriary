using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 


namespace Laba_10
{
	public class SortbyName :  IComparer
	{
		int IComparer.Compare(object ob1, object ob2)
		{
			Place s1 = (Place)ob1;
			Place s2 = (Place)ob2;
			if (s1 != null && s2 != null)
				return String.Compare(s1.SetName, s2.SetName);
			return -2;
		}
	}
}
