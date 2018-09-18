using System;

namespace LearningExceptionFilters
{
    class Program
    {
        class PersonException : Exception
        {
            public PersonException(String name)
            {
                Name = name;
            }
            public String Name { get; set; }
        }
        static void Main(string[] args)
        {
            try
            {
                throw new PersonException("Kim");
                throw new PersonException("Bob");
            }
            catch (PersonException ex) when (ex.Name == "Kim")
            {

                Console.WriteLine("it's from Kim, ignore it");
            }
            
            catch (PersonException ex) when (ex.Name == "Bob")
            { 
                Console.WriteLine("it's from Bob, log it");
            }
            
        }
    }
}
