using System;
using System.Text;
using System.IO;
using System.Net;
//using Xamarin.Forms;
using System.Runtime;
//using test1;

//using Newtonsoft.Json;

namespace consoleTest
{
	class FunctionCallHierarchy{
		/* By: Ekta Bindlish and Arun Thekumparampil
		 * this class gives functions that will be invoked when making calls to API
		 * and receive infromation from the API
		 * this basically encapsulates other functions
		 */

		public bool instaiateUser(string username, string password){
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
		
		//added by Brianna
		public static double[] generateRandomCoordinates ()	{

			double[] currentCoordinates = Coordinates.getCurrentCoordinates ();
			double[] randomCoordinates = new double[3];

			Random rnd = new Random ();

			randomCoordinates [0] = rnd.NextDouble ();
			randomCoordinates [1] = rnd.NextDouble ();
			double plusMinus0 = rnd.NextDouble ();
			double plusMinus1 = rnd.NextDouble ();

			if (plusMinus0 > 0.5)
				randomCoordinates [0] = currentCoordinates[0] + Math.Round(randomCoordinates [0] / 1500, 6);
			else
				randomCoordinates [0] = currentCoordinates[0] - Math.Round(randomCoordinates [0] / 1500, 6);

			if (plusMinus1 > 0.5)
				randomCoordinates [1] = currentCoordinates[1] + Math.Round(randomCoordinates [1] / 1500, 6);
			else
				randomCoordinates [1] = currentCoordinates[1] - Math.Round(randomCoordinates [1] / 1500, 6);

			randomCoordinates [2] = currentCoordinates[2];
			return randomCoordinates;
		}

		//added by Souwarna
		//modified by Luke
		public static string POST_Request(string url, string jsonData)
		{
			// Create a request using a URL that can receive a post. 
			WebRequest request = WebRequest.Create(url);
			// Set the Method property of the request to POST.
			request.Method = "POST";
			// Create POST data and convert it to a byte array.
			string postData = jsonData;
			byte[] byteArray = Encoding.UTF8.GetBytes (postData);
			// Set the ContentType property of the WebRequest.
			request.ContentType = "application/x-www-form-urlencoded";
			// Set the ContentLength property of the WebRequest.
			request.ContentLength = byteArray.Length;
			// Get the request stream.
			Stream dataStream = request.GetRequestStream ();
			// Write the data to the request stream.
			dataStream.Write (byteArray, 0, byteArray.Length);
			// Close the Stream object.
			dataStream.Close ();
			// Get the response.
			WebResponse response = request.GetResponse ();
			// Display the status.
			Console.WriteLine (((HttpWebResponse)response).StatusDescription);
			// Get the stream containing content returned by the server.
			dataStream = response.GetResponseStream ();
			// Open the stream using a StreamReader for easy access.
			StreamReader reader = new StreamReader (dataStream);
			// Read the content.
			string responseFromServer = reader.ReadToEnd ();
			// Display the content.
			Console.WriteLine (responseFromServer);
			// Clean up the streams.
			reader.Close ();
			dataStream.Close ();
			response.Close ();
			return null;
		}

		//added by Suwarna
		public static string GET_Request(string url)
		{
			// Create a request using a URL that can receive a post. 
			WebRequest request = WebRequest.Create(url);
			request.Method = "GET";
			WebResponse response = request.GetResponse();
			// Display the status.
			Console.WriteLine (((HttpWebResponse)response).StatusDescription); // gives the status
			// Get the stream containing content returned by the server.
			Stream dataStream = response.GetResponseStream ();
			// Open the stream using a StreamReader for easy access.
			StreamReader reader = new StreamReader (dataStream);
			// Read the content.
			string responseFromServer = reader.ReadToEnd ();
			// Display the content.
			Console.WriteLine (responseFromServer);
			// Clean up the streams and the response.
			reader.Close ();
			response.Close ();
			return null;
		}
		
		//added by ekta
		public static string DELETE_Request(string url)
		{
			WebRequest request = WebRequest.Create(url);
			request.Method = "DELETE";
			HttpWebResponse response = (HttpWebResponse)request.GetResponse();
			Console.WriteLine (((HttpWebResponse)response).StatusDescription); // gives the status
			return null;
		}

	}	
}