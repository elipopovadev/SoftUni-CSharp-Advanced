﻿using System;

namespace ComparingObjects
{
    public class Person: IComparable<Person>
    {
        public Person(string name, int age, string town)
        {
            this.Name = name;
            this.Age = age;
            this.Town = town;
        }

        public string Name { get; }
        public int Age { get; }
        public string Town { get; }

        public int CompareTo( Person other)
        {
           if(this.Name.CompareTo(other.Name) != 0)
            {
                return this.Name.CompareTo(other.Name);
            }

           if (this.Age.CompareTo(other.Age) != 0)
            {
                return this.Age.CompareTo(other.Age);
            }

            return this.Name.CompareTo(other.Name);        
        }  
    }
}
