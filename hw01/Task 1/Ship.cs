using System;
using System.Collections.Generic;
using System.Text;

namespace Hw_10
{
    class Ship
    {
        //https://www.codewars.com/kata/54fe05c4762e2e3047000add
        //Ahoy matey!
        //You are a leader of a small pirate crew. And you have a plan.With the help of OOP you wish to make a pretty efficient system to identify ships with a heavy booty on board.
        //Unfortunattely for you, people weigh a lot this days, so how do you know if a ship if full of gold and not people?
        //You begin with writing a generic Ship class:

        public int Draft;
        public int Crew;

        public Ship(int draft, int crew)
        {
            Draft = draft;
            Crew = crew;
        }

        public bool IsWorthIt()
        {
            if (Draft - Crew * 1.5 >= 20)
                return true;
            else return false;
        }
    }
}
