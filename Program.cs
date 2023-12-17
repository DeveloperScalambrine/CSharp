using System;
using System.Linq;

namespace CSharp
{
	class Program
	{
		static void Main(string[] args)
		{
			try
			{
				ObjEleStatics.ToPayOrder(ObjEleStatics.Communication);
			}
			catch (ArgumentException ex)
			{
				Console.WriteLine(ex.Message);
			}
		}
	}
}