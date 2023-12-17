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
					Livro l = new Livro
				{
					NumPage = 200,
					Title = "Review",
					Price = 100.00,
				};
				Console.WriteLine(l);
			}
			catch (ArgumentException ex)
			{
				Console.WriteLine(ex.Message);
			}
		}
	}
}