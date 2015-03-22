/*! \file User.cs
 *  \brief A file containing the User Class -created by Brianna Kicia
 * */
namespace UserSpace
{
	/*! \class User
	 *  \brief User 
	 *  
	 *  Provides the class for the people using the application
	 * 
	 */

	public class User
	{
		/**Variables that hold the user's information**/
		private string username, /**< The username */
					   password; /**< The user's password */
		private string[] settings /**< The user's preferred system settings */
					
		/** A constructor.
		* @param username is the value that will set the internal username
		* @param password is the value that will set the internal password
		**/
		User(string username, string password){
			updateUsernameAndPassword (username, password);
		}

		User(){
			updateUsernameAndPassword (String.Empty, String.Empty);
		}

		/**A function that takes no arguments and returns the username and password.
			@return The username, password, and other user information
			*/
		string[] getInfo(){
			return new string[3]; //return username, password, user info
		}

		/**A function that updates the internal login information
		* @param username is the value that will set the internal username
		* @param password is the value that will set the internal password
		**/
		void updateUsernameAndPassword(string username, string password){
			this->username = username;
			this->password = password;
		}

		/**A function that updates the internal user settings
		* @param settings is the array that will be the user's settings
		**/
		void updateSettings(string[] settings){
			this->settings = settings;
		}

		/**A function that returns the username
		 * @return username
		 * */
		string getUsername(){
			return username;
		}

		/**A function that returns the user's password
		 * @return password
		 * */
		string getPassword(){
			return password;
		}

		/**A function that returns the user's settings
		 * @return settings
		 * */
		string[] getSettings(){
			return settings;
		}

		/**A function that updates the user's information
		 * on the database.
		 * */
		void updateUser(){
		}
		
	}
}
