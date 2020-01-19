using System;
using System.Collections.Generic;
using System.Text;

namespace Hw_10
{
    public class Person
    {
        //https://www.codewars.com/kata/55a144eff5124e546400005a 
        //Classy Classes
        //Basic Classes, this kata is mainly aimed at the new JS ES6 Update introducing classes
        //Task
        //Your task is to complete this Class, the Person class has been created.You must fill in the Constructor method to accept a name as string and an age as number, complete the get Info property and getInfo method/Info getter which should return
        //johns age is 34

        public string personName;
        public int personAge;
        public Person(string name, int age)
        {
            personName = name;
            personAge = age;
        }

        public string Info
        {
            get { return $"{personName}s age is {personAge}"; }
        }
    }
}
