/*
 * This program demonstrates basic enum setup and usage
 */

using System;

namespace Enum
{
	class MainClass
	{
		//declare enum and add values
		enum Months { Jan, Feb, March, April, May, June, July, August };

		public static void Main (string[] args)
		{
			//declare variables for demonstration
			int x, y;

			//assign variables to the value of each enum position
			//have to cast the enum objects to an int
			x = (int)Months.Jan;
			y = (int)Months.May;

			//prints the values 0 and 4
			Console.WriteLine (x);
			Console.WriteLine (y);
		}
	}
}
