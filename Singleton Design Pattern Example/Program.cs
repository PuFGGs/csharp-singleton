using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton_Design_Pattern_Example
{
	class Program
	{
		private static Singleton _singleton;
		static void Main(string[] args)
		{
			_singleton = Singleton.GetObject();

			int mycalculation = _singleton.AdditionMethod(10, 52);

			_singleton.SendLog(mycalculation.ToString());

			Console.ReadLine();
		}
	}
}
