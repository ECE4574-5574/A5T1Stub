using System;

namespace test1
{
	class AppQueries{

		/* By: Ekta Bindlish and Arun Thekumparampil
		 * retrieves information about house layout from the server
		 * Parameters: house ID, parameters to retrieve
		 * Returns: string array
		 */
		public string[] retreiveHouseLayout(string houseID, string[] queryParams){
			return null;
		}

		/* By: Ekta Bindlish and Arun Thekumparampil
		 * rerieves information about User History from the server
		 * the app will specify the amount of time to be queried
		 * Parameters: parameters to retrieve
		 * Returns: string array
		 */
		public string[] retreiveUserHistory(string [] queryParams){
			return null;
		}

		/* By: Ekta Bindlish and Arun Thekumparampil
		 * rerieves information about House History from the server
		 * Parameters: house ID, parameters to retrieve
		 * Returns: string array
		 */
		public string[] retreiveHouseHistory(string houseID, string [] queryParams){
			return null;
		}

		/* By: Ekta Bindlish and Arun Thekumparampil
		 * rerieves information about Room History from the server
		 * Parameters: house ID, room ID, parameters to retrieve
		 * Returns: string array
		 */
		public string[] retreiveRoomHistory(string houseID, string roomID, string [] queryParams){
			return null;
		}

		/* By: Ekta Bindlish and Arun Thekumparampil
		 * rerieves information about devices from the server
		 * Parameters: house ID, room ID, device ID, parameters to retrieve
		 * Returns: string array
		 */
		public string[] retreiveDeviceHistory(string houseID, string roomID, string deviceID, string[] queryParams){
			return null;
		}

		/* By: Ekta Bindlish and Arun Thekumparampil
		 * rerieves information about devices from the server
		 * Parameters: string houseID, parameters to retreive
		 * Returns: string array
		 */
		public string[] retreiveEventHistory(string houseID, string [] queryParams){
			return null;
		}
	}
}