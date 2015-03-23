using System;

namespace test1
{
	class FunctionCallHierarchy{
		/* By: Ekta Bindlish and Arun Thekumparampil
		 * this class gives functions that will be invoked when making calls to API
		 * and receive infromation from the API
		 * this basically encapsulates other functions
		 */

		public bool instaiateUser(string username, string password){
		
		
		}

		public bool AuthenticateUser( string username, string password){
		}

		public bool UpdateUser(string username, string password ){
		}

		public bool AddHouse(string username, string houseID){
		}

		public bool DeleteHouse(string houseID){
		}

		public bool UpdateHouse(string houseID){
		}

		public bool AddRoom(string houseID, string roomID){
		}

		public bool DeleteRoom(string houseID, string roomID){
		}

		public bool UpdateRoom(string houseID, string roomID){
		}

		public bool AddDevice(string houseID, string roomID, string deviceID ){
		}

		public bool DeleteDevice(string houseID, string roomID, string deviceID ){
		}

		public bool UpdateDevice(string houseID, string roomID, string deviceID){
		}

		
		public string[] retreiveHousestruct(string houseID, string[] params){
		
		}

		
		public string[] retreiveUserHist(string [] params){

		}

		
		public string[] retreiveHouseHist(string houseID, string [] params){

		}

		
		public string[] retreiveRoomHist(string houseID, string roomID, string [] params){

		}

		
		public string[] retreiveDeviceHist(string houseID, string roomID, string deviceID, string[] params){

		}

		public string[] retreiveEventHist(string houseID, string [] params){

		}
	

		public string[] GetEventUpdates( string houseID){
		}

		public void LocationUpdate(){
		}

		
	}

}