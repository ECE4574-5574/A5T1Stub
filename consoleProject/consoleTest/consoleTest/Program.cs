using System;

namespace consoleTest
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			//DeviceMgr
			FunctionCallHierarchy.GET_Request("http://localhost:49310/api/devicemgr/state/12");
			Console.WriteLine ();

			FunctionCallHierarchy.POST_Request("http://localhost:49310/api/devicemgr/state/12", "check");
			Console.WriteLine ();

			//SIM
			//FunctionCallHierarchy.GET_Request("http://localhost:49310/api/api/sim/configuration/12");
			//Console.WriteLine ();

			//User
			FunctionCallHierarchy.GET_Request("http://localhost:49310/api/user/ekta");
			Console.WriteLine ();
			FunctionCallHierarchy.POST_Request("http://localhost:49310/api/user/ekta", "check");
			Console.WriteLine ();
			FunctionCallHierarchy.DELETE_Request("http://localhost:49310/api/user/ekta");
			Console.WriteLine ();
			FunctionCallHierarchy.POST_Request("http://localhost:49310/api/user/updateposition/ekta", "check");
			Console.WriteLine ();

			//Space
			FunctionCallHierarchy.GET_Request("http://localhost:49310/api/space/12/15");
			Console.WriteLine ();
			FunctionCallHierarchy.POST_Request("http://localhost:49310/api/space/12/15", "check");
			Console.WriteLine ();
			FunctionCallHierarchy.DELETE_Request("http://localhost:49310/api/space/12/15");
			Console.WriteLine ();
			
			//Device
		/*	FunctionCallHierarchy.GET_Request("http://localhost:49310/api/device/12/15/17");
			Console.WriteLine ();
			FunctionCallHierarchy.GET_Request("http://localhost:49310/api/device/12/15");
			Console.WriteLine ();
			FunctionCallHierarchy.GET_Request("http://localhost:49310/api/device/12/15/18");
			Console.WriteLine ();
			FunctionCallHierarchy.GET_Request("http://localhost:49310/api/device/12");
			Console.WriteLine ();
			FunctionCallHierarchy.GET_Request("http://localhost:49310/api/device/12/18");
			Console.WriteLine ();
			FunctionCallHierarchy.POST_Request("http://localhost:49310/api/device/12/15/17","check");
			Console.WriteLine ();
			FunctionCallHierarchy.DELETE_Request("http://localhost:49310/api/device/12/15/17");
			Console.WriteLine ();*/

			//House
			FunctionCallHierarchy.GET_Request("http://localhost:49310/api/house/12");
			Console.WriteLine ();
			FunctionCallHierarchy.POST_Request("http://localhost:49310/api/house/12","check");
			Console.WriteLine ();
			FunctionCallHierarchy.DELETE_Request("http://localhost:49310/api/house/12");
			Console.WriteLine ();
										
			//Events
			FunctionCallHierarchy.POST_Request("http://localhost:49310/api/events/weather","check");
			Console.WriteLine ();
			FunctionCallHierarchy.POST_Request("http://localhost:49310/api/events/devicestate","check");
			Console.WriteLine ();
			FunctionCallHierarchy.POST_Request("http://localhost:49310/api/events/command","check");
			Console.WriteLine ();
			FunctionCallHierarchy.POST_Request("http://localhost:49310/api/events/locationchange/0010","check");
			Console.WriteLine ();
			FunctionCallHierarchy.POST_Request("http://localhost:49310/api/events/locatltime","check");
			Console.WriteLine ();


			Console.ReadLine();
		}
	}
}
