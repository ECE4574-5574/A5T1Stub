using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace test1
{
    class addAndRemove
    {
        // member variable that tells the list of devices associated with the room
        private string[] rooms;
        private string[] houses;
        private string[] devices;

        /* By: Suwarna Poudel
         * adds a house to the user
         *  Parameters: name - name of the house to be added
         * Returns: bool - true if room is added false if room cannot be added for any reason
         */
        public bool addHouse(string name)
        {
            return true;
        }

        /* By: Suwarna Poudel
         * removes a house from the system
         * Parameters: name - name of the house to be removed
         * Returns: bool - true if room is successfully removed else false
         */
        public bool removeHouse(string name)
        {
            return true;
        }

        /* By: Suwarna Poudel
         * adds a Room to the house
         * Parameters: name - name of the room to be added
         *             houseName - name of house where the room will be added
         * Returns: bool - true if room is added false if room cannot be added for any reason
         */
        public bool addRoom(string houseName, string name)
        {
            return true;
        }

        /* By: Suwarna Poudel
         * removes a room from the system
         * Parameters: name - name of the room to be removed
         *             houseName - tells which house the room is located
         * Returns: bool - true if room is successfully removed else false
         */
        public bool removeRoom(string houseName, string name)
        {
            return true;
        }

        /* By: Suwarna Poudel
         * checks if a room exists or not
         * Parameters: name - name of the room to be checked
         * Returns: bool - true if room is found else false
         */
        private bool checkRoom(string name)
        {
            return true;
        }
    
        /* By: Suwarna Poudel
         * checks the hierarchy of the system  
         * Parameters: None
         * Return: true if the hierarchy is proper
        */
        public bool checkHierarchy()
        {
            return true;
        }

        /* By: Suwarna Poudel
         * checks if a device exists in the house or not
         * Parameters: deviceId - deviceId to be checked
         * Returns: bool - true if device exists else false
         */ 
        private bool checkDevice(string deviceId)
        {
            return true;
        }

        /* By: Suwarna Poudel
         * adds a device to the room 
         * Parameters: roomName: tells which room the device belongs to
         *             deviceId: device that is being added
         *             houseName: tells which house the device is in
         * Return: if the device is successfully added then the function will return its deviceId
         *         else returns ERROR MESSAGES if the deviceId is not found or if the room is not found
         */
        public string addDevice(string houseName, string roomName, string deviceId)
        {
            return deviceId;
        }

        /* By: Suwarna Poudel
         * removes a device from the room 
         * Parameters: deviceId: device Id that is to be removed
         * Return: true if successfully removed else false
         */
        public bool removeDevice(string deviceId)
        {
            return true;
        }

        /* By: Suwarna Poudel
         * adds multiple devices to the room in a house
         * Parameters: roomName: tells which room the devices belongs to
         *             deviceId: devices that are being added
         *             houseName: tells which house to add them
         * Return: if all the devices are successfully added then the ArrayList will be empty
         *         else the ArrayList will contain the string of deviceId's that are not successfully added
        */
        public ArrayList addDevices(string houseName, string roomName, string[] deviceId)
        {
            return failedDevices;
        }


        /*
         * By: Suwarna Poudel
         * This is a main function which just does some unit testing on the stub functions 
         * that are created above.
         */
       /* static void Main(string[] args)
        {
            Program a = new Program();
            ArrayList retVal = new ArrayList();
            string[] test = {"one","two","three","four"};
            bool check;
            check = a.addRoom("Living");
            retVal = a.addDevices("123", test);
            //Console.Write(test);
            if (retVal.Count > 0)
                Console.Write("failed");
            while (true) ;
            
        }*/
    }
}
