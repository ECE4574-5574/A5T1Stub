using System;
using System.IO;
using System.Net;
using Xamarin.Forms;
using System.Runtime;
using test1;
//using System.Web;


//using Newtonsoft.Json;

namespace test1
{
	class FunctionCallHierarchy{
		/* By: Ekta Bindlish and Arun Thekumparampil
		 * this class gives functions that will be invoked when making calls to API
		 * and receive infromation from the API
		 * this basically encapsulates other functions
		 */

		public bool instaiateUser(string username, string password){
			string url = "http://testHomeApi.com/JSON?instantiateUser=" + username +
			             "&password=" + password;

			JsonValue json = await instaiateUserAsync (url);

			return false;
		
		}

		public bool AuthenticateUser( string username, string password){
			return false;
		}

		public bool UpdateUser(string username, string password ){
			return false;
		}

		public bool AddHouse(string username, string houseID){
			return false;
		}

		public bool DeleteHouse(string houseID){
			return false;
		}

		public bool UpdateHouse(string houseID){
			return false;
		}

		public bool AddRoom(string houseID, string roomID){
			return false;
		}

		public bool DeleteRoom(string houseID, string roomID){
			return false;
		}

		public bool UpdateRoom(string houseID, string roomID){
			return false;
		}

		public bool AddDevice(string houseID, string roomID, string deviceID ){
			return false;
		}

		public bool DeleteDevice(string houseID, string roomID, string deviceID ){
			return false;
		}

		public bool UpdateDevice(string houseID, string roomID, string deviceID){
			return false;
		}

		
		public string[] retreiveHousestruct(string houseID, string[] queryParams){
			return null;
		}

		
		public string[] retreiveUserHist(string [] queryParams){
			return null;
		}

		
		public string[] retreiveHouseHist(string houseID, string [] queryParams){
			return null;
		}

		
		public string[] retreiveRoomHist(string houseID, string roomID, string [] queryParams){
			return null;
		}

		
		public string[] retreiveDeviceHist(string houseID, string roomID, string deviceID, string[] queryParams){
			return null;
		}

		public string[] retreiveEventHist(string houseID, string [] queryParams){
			return null;
		}
	

		public string[] GetEventUpdates( string houseID){
			return null;
		}

		public double[] LocationUpdate(){
			return Coordinates.getCurrentCoordinates();

		}

		private async Task<JsonValue> instaiateUserAsync (string url)
		{
			// Create an HTTP web request using the URL:
			HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create (new Uri (url));
			request.ContentType = "application/json";
			request.Method = "GET";

			// Send the request to the server and wait for the response:
			using (WebResponse response = await request.GetResponseAsync ())
			{
				// Get a stream representation of the HTTP web response:
				using (Stream stream = response.GetResponseStream ())
				{
					// Use this stream to build a JSON document object:
					JsonValue jsonDoc = await Task.Run (() => JsonObject.Load (stream));
					Console.Out.WriteLine("Response: {0}", jsonDoc.ToString ());

					// Return the JSON document:
					return jsonDoc;
				}
			}
		}

	}

}