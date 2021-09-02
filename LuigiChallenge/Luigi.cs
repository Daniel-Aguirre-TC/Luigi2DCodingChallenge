using System;
namespace LuigiChallenge
{
    public class Luigi
    {
        public Luigi()
        {
        }


//Guide Luigi home by following the trail of "0"s from left to right and top to bottom in the 2D matrix.

//Give him directions with two commands:

//"Down" or "Right";

//Example:
//input:

//        [4,0,4]
//        [5,0,0]
//        [6,9,0]
//        [8,3,0]

//        output:

//String "Down Right Down Down"

//(Note: In all the tests Luigi will have clear path.So there will only be a "0" below or to the right of each other.No isolated "0"s or "0"s moving back left.)


        public string GoHome2D(int[][] map)
        {
            string pathHome = string.Empty;
            // loop through all arrays in map
            for (int i = 0; i < map.GetLength(0); i++)
            {
                // loop through each value inside of each array
                for (int j = 0; j < map[i].Length; j++)
                {
                    // if it's not the first element in the array
                    if (j > 0)
                    {
                        // if the number to the left is 0 and I'm currently on zero
                        if (map[i][j - 1] == 0 && map[i][j] == 0)
                        {
                            pathHome += "Right ";
                        }
                    }
                    // if it's not the last deminsion
                    if (i < map.GetLength(0) - 1)
                    {
                        if (map[i + 1][j] == 0 && map[i][j] == 0)
                        {
                            pathHome += "Down ";
                            break;
                        }
                    }
                }
            }
            return pathHome.TrimEnd();
        }
    }
}
