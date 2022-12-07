using System;

namespace classStruct {

    class Program {

        static void Main(string[] args) 
        {
            // Class
            Console.WriteLine("***** Class *****");
            Rectangle rectangleClass = new Rectangle();
            Console.WriteLine("Calculation of Rectangle Area BY Class: {0}", rectangleClass.CalculateArea());

            // Struct 
            Console.WriteLine("***** Struct *****");
            RectangleStruct rectangleStruct; // OR can be as "RectangleStruct rectangleStruct = new RectangleStruct();"
            rectangleStruct.shortEdge = 3;
            rectangleStruct.longEdge = 4;
            Console.WriteLine("Calculation of Rectangle Area BY Struct: {0}", rectangleStruct.CalculateArea());

        }
    }

    class Rectangle {
        public int shortEdge;
        public int longEdge;

        public Rectangle() {
            shortEdge = 3;
            longEdge = 4;
        }

        public long CalculateArea() 
        {
            return this.shortEdge * this.longEdge;
        }
    }

    struct RectangleStruct {
        public int shortEdge;
        public int longEdge;

        public long CalculateArea() 
        {
            return this.shortEdge * this.longEdge;
        }
    }
}
