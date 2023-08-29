using System;
namespace Exercise_1
{
    class Dice
    {
        private int sides;
        //Used to indicate the face of a dice.

        public Dice()
        {
            this.sides = 6;
        }
        //a constructor used to initialize a Dice object with a default number of faces of 6.
        

        public Dice(int sides)
        {
            this.sides = sides;
        }
        //a constructor used to initialize a Dice object with a argument "sides" is number of faces.

        public int Side // property for Side
        {
            get { return this.sides; }  //a method get number of faces.
            set { this.sides = value; } //a method set number of faces.
        }

        public int Roll()
        {
            return (new Random()).Next(1, this.sides);
        }
        //a method generate a random number from 1 to sides.

    }
}