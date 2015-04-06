using System;

namespace Update
{
	class UpdateClass
	{
		/* By: Roudenniel Decastro
		 * Sends list of current rooms added on the app to be stored
		 * on the server
		 * Parameters: none
		 * Returns: boolean
		 */
		public bool sendListOfRooms(){
			return true;
			
		}
		
		/* By: Roudenniel Decastro
		 * this returns the list of rooms from the server to be displayed
		 * provides most current list for the app
		 * Parameters: none
		 * Returns: array: this is the list of rooms stored on the server
		 */
		//public roomList[] receiveListOfRooms(){
		//	roomList[] rooms;
		//	return rooms;
		//}
		public string[] receiveListOfRooms(){
			string[] rooms;
			return null;//rooms;
		}
		/* By: Roudenniel Decastro
		 * this sends the current location of the user to be stored on the server
		 * Parameters: int x: this is the x position relative to the user within their house 
		 	     : int y: this is the y position relative to the user within their house
		 	     : int z: this is the z position relative to the user within their house
		 * Returns: boolean
		 */
		public bool sendCurrentLocation(int x, int y, int z){
			return true;	
		}
		
		/* By: Roudenniel Decastro
		 * this pulls the current location of the the user that is associated with roomId
		 * Parameters: none
		 * Returns: string: this is the roomId
		 */
		public string receiveCurrentLocation(){
			return null;
			/*int x, y, z;
			Coordinates pos = new Coordinates();
			x = pos.getX();
			y = pos.getY();
			z = pos.getZ();
			string roomId;
			return roomId;*/
		}
		
		/* By: Roudenniel Decastro
		 * this pulls what house the user is in from the server
		 * Parameters: none
		 * Returns: string: the name of the current house
		 */
		public string receiveCurrentHouse(){
			return null;//houseId;
		}

		/* By: Roudenniel Decastro
		 * this pulls the device information from the server (on/off)
		 * Parameters: none
		 * Returns: array: this contains the list of devices that are on/off
		 */
		//public deviceList[]  receiveDeviceSettings(){
			//deviceList[] devicesState;
		public string[]  receiveDeviceSettings(){
			string[] deviceState;
			return null;//deviceState;
		}
		
		/* By: Roudenniel Decastro
		 * this sends the current devices settings(which are on/off) to the server
		 * Parameters: none
		 * Returns: boolean
		 */
		public bool sendDeviceSettings(){
			return true;
			
		}


		/* By: Roudenniel Decastro
		 * Main function that performs unit testing on the methods above
		 */
/*		public static void Main (string[] args)
		{
			int x,y,z;
			devices[] device;
			rooms[] room;
			string roomId, houseId;
			Coordinates pos = new Coordinates();
			UpdateClass test = new UpdateClass();
			x = pos.getX();
			y = pos.getY();
			z = pos.getZ();
			test.sendListOfRooms();
			test.sendCurrentLocation(x,y,z);
			test.sendDeviceSettings();
			room = test.receiveListOfRooms();
			device = test.receiveDeviceSettings();
			roomId = test.receiveCurrentLocation();
			houseId = test.receiveCurrentHouse();

		}
*/	}
}
