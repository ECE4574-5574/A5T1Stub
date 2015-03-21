/*! \file Coordinates.cs
 *  \brief A file containing the Coordinate
 * */
namespace CoordinateSpace
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
		private int x, /**< The user's X-coordinate */
					y, /**< The user's Y-coordinate */
					z; /**< The user's Z-coordinate */

		/** A constructor.
		* @param x is the value that will set the internal X-coordinate
		* @param y is the value that will set the internal Y-coordinate
		* @param z is the value that will set the internal Z-coordinate
		**/
		Coordinates(int x, int y, int z){
			setCoordinates (x, y, z);
		}

		Coordinates(){
			setCoordinates (0, 0, 0);
		}

		/**
			Takes no arguments and returns all coordinates of the user.
			@return The coordinates
			*/
		int[] getCoordinates(){
			return new int[3]; //return x,y,z coordiates
		}

		/**A function that sets the internal coordinates
		 * @param x is the value that will set the internal X-coordinate
		 * @param y is the value that will set the internal Y-coordinate
		 * @param z is the value that will set the internal Z-coordinate
		 * */
		void setCoordinates(int x, int y, int z){
			this->x = x;
			this->y = y;
			this->z = z;
		}

		/**A function that returns the X-coordinate
		 * @return X-Coordinate
		 * */
		int getX(){
			return x;
		}

		/**A function that returns the Y-coordinate
		 * @return Y-Coordinate
		 * */
		int getY(){
			return y;
		}

		/**A function that returns the Z-coordinate
		 * @return Z-Coordinate
		 * */
		int getZ(){
			return z;
		}

		/**A function that updates the inner coordinates using GPS
		 * and Wi-Fi.
		 * */
		void updateCoordinates(){
		}
		
	}
}