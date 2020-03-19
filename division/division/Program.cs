/*
 * Created by SharpDevelop.
 * User: Vendip
 * Date: 3/19/2020
 * Time: 6:38 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace division
{
	public static class division{
		public static double div(double a, double b){
			return a/b;
		}
	}
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine(division.div(25,7));
			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}