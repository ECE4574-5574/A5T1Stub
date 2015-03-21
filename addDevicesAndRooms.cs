using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleApplication1
{
    class Program
    {
        /* BY: Suwarna Poudel
         * adds a Room to the house
         * Parameters: name - name of the room to be added
         * Returns: bool - true if room is added false if room already exists
         */ 
        public bool addRoom(string name)
        {
            return true;
        }

        /* BY: Suwarna Poudel
         * checks if a room exists or not
         * Parameters: name - name of the room to be checked
         * Returns: bool - true if room is found else false
         */ 
        private bool checkRoom(string name)
        {
            return true;
        }

        /* BY: Suwarna Poudel
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
         * Return: if the device is successfully added then the function will return its deviceId
         *         else returns ERROR MESSAGES if the deviceId is not found or if the room is not found
         */
        public string addDevice(string roomName, string deviceId)
        {
            if (!checkRoom(roomName)) // room not found
                return "ERROR - ROOM NOT FOUND";
            if (!checkDevice(deviceId))
                return "ERROR - DEVICE NOT FOUND";
            return deviceId;
        }


        /* By: Suwarna Poudel
         * adds multiple devices to the room
         * Parameters: roomName: tells which room the devices belongs to
         *             deviceId: devices that are being added
         * Return: if all the devices are successfully added then the ArrayList will be empty
         *         else the ArrayList will contain the string of deviceId's that are not successfully added
        */
        public ArrayList addDevices(string roomName, string[] deviceId)
        {
            ArrayList failedDevices = new ArrayList();
            string ret;

            for (int i = 0; i < deviceId.Length; i++)
            {
                ret = addDevice(roomName, deviceId[i]);
                if (ret != deviceId[i])
                    failedDevices.Add(deviceId[i]);
            }
            return failedDevices;
        }


        /*
         * By: Suwarna Poudel
         * This is a main function which just does some unit testing on the stub functions 
         * that are created above.
         */
        static void Main(string[] args)
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
            
        }
    }
}
