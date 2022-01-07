using Exceptions;
using System;
using System.Collections.Generic;
using System.Text;



namespace HomeworkException
{
//    //- throw ArgumentException for negative age 

//- throw ApplicationException for age greater than 100

//- throw ApplicationException for name length lower than 2
    public class Dog
    {
        private string name;
        private int age;

        public Dog(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name 
        { 
            get
            {
                return this.name;
            }
            set
            {
                if (value.Length> 2)
                {
                    this.name = value;
                }
                else
                {
                    throw new InvalidName();
                }
            }
        }
        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                if (value > 0 && value <=100)
                {
                    this.age = value;
                }
                else
                {
                    if (value < 0)
                    {
                        throw new NegativeAge();
                    }
                    else
                    {
                        throw new InvalidAge();
                    }

                }

                
            }
        }
    }
    
    
}
