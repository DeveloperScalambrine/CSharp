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
				/* 
				ExercisesPg46.IsNotEqual();
				ExercisesPg46.OrderDesc();
				*/

				// ExercisesPg46.CalcularRaizes();

				Console.WriteLine(ExercisesPg46.IdealWeight());									

			}
			catch (ArgumentException ex)
			{
				Console.WriteLine(ex);
			}
		}
	}
}