using System;
using System.Collections.Generic;
using System.Text;

namespace Hw_10
{
    class Ball
    {
        //https://www.codewars.com/kata/53f0f358b9cb376eca001079 
        //Regular Ball Super Ball
        //Create a class Ball.
        //Ball objects should accept one argument for "ball type" when instantiated.
        //If no arguments are given, ball objects should instantiate with a "ball type" of "regular."

        public string ballType { get; set; }

        public Ball(string ballType)
        {
            this.ballType = ballType;
        }

        public Ball()
        {
            ballType = "regular";
        }
    }
}
