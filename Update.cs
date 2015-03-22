using System;

namespace Update
{
	class UpdateClass
	{
		/* By: Roudenniel Decastro
		 * updates the list of rooms from the server
		 * grabs information from the server and updates list 
		 * on the app to be displayed
		 * Parameters: none
		 * Returns: none
		 */
		public void updateListOfRooms(){
		
		}

		/* By: Roudenniel Decastro
		 * updates current location of user
		 * associates the room with the location in order
		 * for later learning algorithm
		 * Parameters: room id
		 * Returns: none
		 */
		public void updateLocation(string roomId){
			
		}

		/* By: Roudenniel Decastro
		 * updates the list of devices connected to the HUB
		 * grabs information from the server and updates list 
		 * on the app to be displayed
		 * Parameters: none
		 * Returns: none
		 */
		public void updateListOfDevices(){
			
		}

		/* By: Roudenniel Decastro
		 * updates the list of devices on throughout the
		 * entire house for the app
		 * Parameters: none
		 * Returns: none
		 */
		public void updateDevicesOn(){
			
		}

		/* By: Roudenniel Decastro
		 * update the current room that the user is in
		 * in order for the app to always have the most current information
		 * Parameters: room Id
		 * Returns: none
		 */
		public void updateCurrentRoom(string roomId){
			
		}


		/* By: Roudenniel Decastro
		 * Main function that performs unit testing on the methods above
		 */
		public static void Main (string[] args)
		{
			UpdateClass test = new UpdateClass();
			test.updateListOfDevices ();
			test.updateListOfRooms ();
			test.updateDevicesOn ();
			test.updateCurrentRoom ();
			test.updateLocation ();

		}
	}
}
