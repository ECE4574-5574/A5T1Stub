/*! \file Coordinates.cs
 *  \brief A file containing the Coordinate
 * */
namespace test1
{
	/*! \class Coordinates
	 *  \brief User Coordinates
	 *  
	 *  Provides interface for users to access information related to
	 * the user's coordinates.
	 * 
	 */

	public class Coordinates
	{
		/**Variables that hold the coordinates**/
		private double longitude, /**< The user's Longitude */
					latitude; /**< The user's Latitude */

		/** A constructor.
		* @param x is the value that will set the internal X-coordinate
		* @param y is the value that will set the internal Y-coordinate
		* @param z is the value that will set the internal Z-coordinate
		**/
		Coordinates(double longitude, double latitude){
			setCoordinates (longitude, latitude);
		}

		Coordinates(){
			setCoordinates (0, 0);
		}

		static double[] getCurrentCoordinates(){
			return null;
		}

		/**
			Takes no arguments and returns all coordinates of the user.
			@return The coordinates
			*/
		double[] getCoordinates(){
			return new double[2]; //return Longitude and Latitude coordiates
		}

		/**A function that sets the internal coordinates
		 * @param Longitude is the value that will set the instance's Longitude
		 * @param Latitude is the value that will set the instance's Latitude
		 * */
		void setCoordinates(double longitude, double latitude){
		}

		void setCoordinates(double[] coordinates){
			
		}

		/**A function that returns the Longitude
		 * @return X-Coordinate
		 * */
		double getLong(){
			return longitude;
		}

		/**A function that returns the Y-coordinate
		 * @return Y-Coordinate
		 * */
		double getLat(){
			return latitude;
		}

		/**A function that updates the inner coordinates using GPS
		 * and Wi-Fi.
		 * */
		void updateCoordinates(){
		}
		
	}
}