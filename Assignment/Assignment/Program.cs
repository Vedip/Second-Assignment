/*
 * Created by SharpDevelop.
 * User: Vendip
 * Date: 3/19/2020
 * Time: 6:28 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Assignment
{
	public static class subtraction{
		public static double sub(double a, double b){
			return a-b;
		}
	}
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine(subtraction.sub(10, 5));
			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}