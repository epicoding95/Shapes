namespace Shapes.Models
{
    //////inital class setup
        public class Rectangle
    {
        public int Length {get; set;}
        public int Width {get; set;}
     ////////constructor setup
        public Rectangle (int sideLength, int sideWidth)
        {
            Length = sideLength;
            Width = sideWidth;
        }
        //////// calculates the area and determines if its a rectangle
        public int GetArea()
        {
            return Length * Width;
        }
        ///// returns true/false if its a rectangle
        public bool IsSquare()
        {
            if (Length == Width)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
         interface IMotor
            {
         string OnSwitch();
            }   

                 public class CoffeeMachine : IMotor
                {
                public string OnSwitch()
                {
                    return "Bubble bubble hiss.";
                }
                }



    }
}