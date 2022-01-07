using System;
using Exceptions;

namespace HomeworkException
{

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Dog dog = new Dog("Bo", 5);
            }
            catch (InvalidName ex)
            {
                Console.WriteLine(ex.Message); 
            }

            try
            {
                Dog dog = new Dog("ALunelu", -1);
            }
            catch (NegativeAge ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                Dog dog = new Dog("Azorica", 102);
            }
            catch (InvalidAge ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
