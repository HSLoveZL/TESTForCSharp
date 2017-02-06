using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TESTForCSharp
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello,World!");
			Console.WriteLine("You have entered {0} arguments from the keyboard!", args.Length);
			for(int i = 0; i < args.Length; i++)
			{
				Console.WriteLine("{0}", args[i]);
			}
		}
	}
}
