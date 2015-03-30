using System;

namespace consoleTest
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			//Console.WriteLine ("Hello World!");
			FunctionCallHierarchy.POST_Request("http://localhost:49310/api/events/locationchange/0010", "check");
		}
	}
}
