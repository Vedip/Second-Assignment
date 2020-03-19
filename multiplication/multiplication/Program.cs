/*
 * Created by SharpDevelop.
 * User: Vendip
 * Date: 3/19/2020
 * Time: 6:41 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace multiplication
{
	public static class multiplication{
		public static double mul(double a, double b){
			return a*b;
		}
	}
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine(multiplication.mul(10,2));
			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}