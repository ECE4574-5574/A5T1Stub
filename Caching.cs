/*! \file Caching.cs
 *  \brief A file containing the caching system
 * */

using System;

namespace CachingSpace
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

        /** Hashes user credentials and stores them locally in the cache
         * @param name is the string value for the user's username
         * @param pass is the string value for the user's password
         * @return a boolean of value true if the operation was successful
         **/
        public bool hashAndCacheCredentials(string name, string pass)
        {
            return true;
        }  
        
        /** Stores a user preferences for the UI in the cache
         * @param uiElement is the id of an element of the UI
         * @param elementProperty is a single property of the element
         * @return a boolean of value true if the operation was successful
         **/
        public bool cacheUserPreference(string uiElement, string elementPropery)
        {
            return true;
        } 

        /** Retrieves a user preference for the UI from the cache
         * @param uiElement is the id of an element of the UI
         * @return a string of the value of the element property
         **/
        public string getCachedUserPreference(string uiElement)
        {
            return elementProperty;
        }

         /** Stores a device preference UI in the cache
         * @param deviceId is the id of the device
         * @param deviceProperty is a single property of the device
         * @return a boolean of value true if the operation was successful
         **/
        public bool cacheDeviceProperty(string deviceId, string deviceProperty)
        {
            return true;
        } 

        /** Retrieves a device preference from the cache
         * @param deviceId is the id of the device
         * @return a string of the value of the device property
         **/
        public string getCachedDeviceProperty(string deviceId)
        {
            return deviceProperty;
        }
	
        /*
         * Main function that performs unit testing on the methods above
         */public static void Main (string[] args)
        {
            UpdateClass test = new UpdateClass();
            test.hashAndCacheCredentials ();
            test.cacheUserPreference ();
            test.getCachedUserPreference ();
            test.cacheDeviceProperty ();
            test.getCachedDeviceProperty ();
        }

    }
}
