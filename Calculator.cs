using System;

namespace AreaCalculator
{
    public static class AreaCalculator
    {
        public static double getsquarearea(int width, int height)
        {
            return getparallelogramarea(width, height);
        }

        public static double getsquarearea(string shapeWidth, string shapeHeight)
        {
            double _shapewidth = 0;
            double _shapeHeight = 0;
            string[]numList = { "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten" };

            for (int x = 0; x <= 9; x++)
            {
                if (numList[x] == shapeWidth.ToLower())
                {
                    _shapewidth = x + 1;
                }
                if (numList[x] == shapeHeight.ToLower())
                {
                    _shapeHeight = x + 1;
                }
            }

            double totalArea = _shapewidth * _shapeHeight;
            return Math.Round(totalArea, 2);
        }

        public static double getrectanglearea(int shapeWidth, int shapeHeight)
        {
            return getparallelogramarea(shapeWidth, shapeHeight);
        }

        public static double getrianglearea(int shapeWidth, int shapeHeight)
        {
            return getparallelogramarea(shapeWidth, shapeHeight /2);
        }

        public static double getparallelogramarea(int shapeWidth, int shapeHeight)
        {
            double totalArea = shapeWidth * shapeHeight;
            return Math.Round(totalArea, 2);
        }

        public static double getCircleRadius(int shapeHeight)
        {
            return getcirclediameter(shapeHeight /2);
        }

        public static double getcirclediameter(int shapeHeight)
        {
            double diameter = shapeHeight;
            return Math.Round(diameter, 2);
        }
    }
}
