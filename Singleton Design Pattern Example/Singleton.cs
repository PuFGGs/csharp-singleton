using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton_Design_Pattern_Example
{
	class Singleton
	{
		private Singleton() {}

		private static Singleton _object;

		public static Singleton GetObject()
		{
			if (_object == null)
				_object = new Singleton();

			return _object;
		}

		public void SendLog(string msg)
		{
			Console.WriteLine($"Singleton.SendLog(message: \"{msg}\")");
		}

		public int AdditionMethod(int n1, int n2)
		{
			return n1 + n2;
		}
	}
}
