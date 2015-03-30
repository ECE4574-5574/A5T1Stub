using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace consoleTest
{	
	class MainClass
	{
		//JSON parsing added by Cole and Denny
		public class JSONCoordinates
		{
			public string x { get; set; }
			public string y { get; set; }
			public string z { get; set; }

		}

		public class JSONUsers
		{
			public string Username { get; set; }
			public int UserID { get; set; }
			public string Password { get; set; }
			public JSONCoordinates coordinates { get; set; }
		}

		public class JSONConfiguration
		{
			public string storageLocation { get; set; }
			public List<JSONUsers> users { get; set; }
		}

		public static void Main (string[] args)
		{
			// this is temporary until input arguments are 
			// implemented to obtain JSON through stream
			const string json = 
				"{" +
				"	\"storageLocation\" : \"123.45.67.890\"," +
				"	\"users\" : [{ \"Username\":\"John\", \"UserID\":369, \"Password\":\"MyPass\", \"Coordinates\": { \"x\":\"1.123456\", \"y\":\"2.123456\", \"z\":\"3.123456\"}}," +
				"		         { \"Username\":\"Jacob\",\"UserID\":123, \"Password\":\"HisPass\", \"Coordinates\": { \"x\":\"4.123456\", \"y\":\"5.123456\", \"z\":\"6.123456\"}" +
				"   }]" +
				"}";

			// Deserialize the JSON placing information in their associated class
			var myConfig = JsonConvert.DeserializeObject<JSONConfiguration> (json);

			// Write the information to console
			Console.WriteLine ("Storage Location: {0}\n", myConfig.storageLocation);

			foreach ( JSONUsers item in myConfig.users ) {
				Console.WriteLine ("Username {0}, \nUser ID: {1}, \nPassword: {2}", item.Username, item.UserID.ToString(), item.Password);
				Console.WriteLine ("Latitude: {0}, Longitude {1}, Amplitude {2}\n", item.coordinates.x, item.coordinates.y, item.coordinates.z);

			}

			//API calls added by Luke, Ekta and Arun

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

			Console.WriteLine("Press any key to continue...");
			Console.ReadLine();
		}
	}
}
