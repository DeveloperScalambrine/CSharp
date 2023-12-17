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
				LightBulb lightBulb = new LightBulb("Ligada");
				lightBulb.StateOfLightBulb();
				lightBulb.Off();
				lightBulb.On();				
			}
			catch (ArgumentException ex)
			{
				Console.WriteLine(ex.Message);
			}
		}
	}
}