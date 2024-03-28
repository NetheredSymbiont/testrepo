using System;

namespace Circle_Calc
{
    class Program
    {
        enum Result {Continue,Stop}
		
		static Result calc()
		{
			Console.WriteLine("Input the radius (0 to exit)\n");
			double r = Convert.ToDouble(Console.ReadLine());
			if(r < 0)
			{
				Console.WriteLine("Radius can't be -ve!\n");
				return Result.Continue;
			}
			else if(r  == 0)
			{
				return Result.Stop;
			}
			Console.WriteLine($"\nThe perimeter is {2*Math.PI*r}\n");
			return Result.Continue;
		}
		
		static void Main(string[] args)
        {
            Result result;
			Console.Title = "Circle Perimeter Calculator";
			do
			{
				result = calc();
			} while(result != Result.Stop);
        }
    }
}
