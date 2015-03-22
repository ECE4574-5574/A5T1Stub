/*! \file Caching.cs
 *  \brief A file containing the caching system
 * */

using System;

namespace test1
{
    /*! \class CachingSystem
     *  \brief preserves persistent information in cache
     *
     * Provides an interface for caching information for user credentials,
     * user preferences, and device preferences. The implementation is 
     * generic such that it can work for any user preference or device
     * property through the use of an identification value and property.
     *
     */

    public class CachingSystem
    {

        public CachingSystem()
        {
        }

        /* By: Cole Padden
         * Hashes user credentials and stores them locally in the cache
         * @param user cedentials in form of User class
         * @return a boolean of value true if the operation was successful
         */
        public bool hashAndCacheCredentials(User credentials)
        {
            return true;
        }  
        
        /* By: Cole Padden
         * Passes the cached username and password to the applications
         * @return the username and password of the datatype user
         */
        public user getCachedCredentials()
        {
        	return myUser;
        }
        
        /* By: Cole Padden
         * Stores a user preferences for the UI in the cache
         * @param uiElement is the id of an element of the UI
         * @param elementProperty is a single property of the element
         * @return a boolean of value true if the operation was successful
         */
        public bool cacheUserPreference(string uiElement, string[] elementPropery)
        {
            return true;
        }
        
        /* By: Cole Padden
         * Retrieves a user preference for the UI from the cache
         * @param uiElement is the id of an element of the UI
         * @return a string array of the element properties
         */
        public string getCachedUserPreference(string uiElement)
        {
            return elementProperty[];
        }

        /* By: Cole Padden
         * Stores a device preference UI in the cache
         * @param deviceId is the id of the device
         * @param deviceProperty is a single property of the device
         * @return a boolean of value true if the operation was successful
         */
        public bool cacheDeviceProperty(string deviceId, string[] deviceProperty)
        {
            return true;
        } 

        /* By: Cole Padden
         * Retrieves a device preference from the cache
         * @param deviceId is the id of the device
         * @return a string array of the the device properties
         */
        public string getCachedDeviceProperty(string deviceId)
        {
            return deviceProperty[];
        }
	
        /* By: Cole Padden
         * Stores a houses rooms
         * @param houseId is the id of the house
         * @param rooms is the rooms of the house
         * @return a boolean of value true if the operation was successful
         */
        public bool cacheHouseRooms(string houseId, string[] rooms)
        {
            return true;
        } 

        /* By: Cole Padden
         * Retrieves cached rooms of a house
         * @param houseId is the id of the device
         * @return a string array of the rooms
         */
        public string getCachedDeviceProperty(string houseId)
        {
            return rooms[];
        }	
	
        /* By: Cole Padden
         * Stores the authentication token from the server
         * @param authToken is the token from the server
         * @return a boolean of value true if the operation was successful
         */
        public bool cacheAuthToken(string authToken)
        {
            return true;
        } 

        /* By: Cole Padden
         * Checks validity of the authentication token
         * @param authToken
         * @return a boolean whether token is valid or not
         */
        public string checkAuthToken(string authToken)
        {
            return true;
        }		
	
        /*
         * Main function that performs unit testing on the methods above
         */
  /*    public static void Main (string[] args)
        {
            CachingSystem test = new CachingSystem();
            test.hashAndCacheCredentials ();
            test.cacheUserPreference ();
            test.getCachedUserPreference ();
            test.cacheDeviceProperty ();
            test.getCachedDeviceProperty ();
        }
	*/
    }
}
