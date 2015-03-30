using System;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;

namespace parseJson
{

	class MainClass
	{

		public static void Main (string[] args)
		{


			// this is temporary until web sockets are implemented
			// string representation of json data

			const string jsonData =
			"{" +
			"	\"storageLocation\":\"54.152.190.217\"," +
			"	\"users\": [" +
			"		{" +
			"			\"user1\": [" + 
			"				{" + 
			"					\"UserID\": 12345" +
			"				}," +
			"				{" +
			"					\"Password\": \"thePassword\"" +
			"				}" +
			"			]," +
			"			\"user2\": [" +
			"				{" +
			"					\"UserID\": 67890" +
			"				}," +
			"				{" +
			"					\"Password\": \"secondPassword\"" +
			"				}" +
			"			]" +
			"		}" +
			"	]" +
			"}";


			var parsedJson = JObject.Parse (jsonData);

			foreach (System.Collections.Generic.KeyValuePair<string, Newtonsoft.Json.Linq.JToken> pair in parsedJson)
			{
				// Console.WriteLine (pair.Key);

				if (pair.Key == "storageLocation") {
					Console.WriteLine ("Storage Location = " + pair.Value.ToString());
				}

				else if (pair.Key == "users") {
					Console.WriteLine ("Users = " + pair.Value.ToString());
				}

			}
				
			// wait for keypress to close console
			Console.WriteLine("Press any key to continue...");
			Console.ReadKey();
		}
	}
}