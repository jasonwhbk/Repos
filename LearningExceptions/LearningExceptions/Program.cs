using System;

namespace LearningExceptions
{
    class Program
    {
        class Person
        {
            private string name;

            public String Name
            {
                get { return name; }
                set {
                    try
                    {
                        if (value == null)
                            throw new NullReferenceException("name must have a value");
                        name = value;
                    }
                    catch(Exception)
                    {
                        Console.WriteLine("name can not be null");
                        throw;
                    }
                }
            }

        }
        static void Main(string[] args)
        {
            try
            {
                var person = new Person();
                person.Name = null;
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

                
        }
    }
}
