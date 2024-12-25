using System;
namespace Exercise {
    public class Person {
        private  string firstName;
        private string lastName;
        private int age;

            public string FirstName{
                get{return firstName;}
                set{firstName = value;}
            }

            public string LastName{
                get{return lastName;}
                set{lastName = value;}
            }
            public int Age {
                get { return age; }
                set { if (value < 0) 
                { age = 0;
                Console.WriteLine("Attempted to set age to an invalid value. Set age to 0 instead.");
                } else {
                    age = value;
        }
    }
} 
         public Person()
        {
            this.FirstName = "";
            this.LastName = "";
            this.Age =0;
        }
            public Person(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }
    }
    class Program{
        static void Main(string [] args ){
            Person p = new Person("Henry","Boswald",33);
            Person p2 = new Person("Lola","Boswald",25);
            Person p3 = new Person("Emilia","Hill",-5);
            Person p4 = new Person("Lucius","Hill",45);
            Console.WriteLine($"{p.FirstName} {p.LastName} is {p.Age} Years Old.");
            Console.WriteLine($"{p2.FirstName} {p2.LastName} is {p2.Age} Years Old.");
            Console.WriteLine($"{p3.FirstName} {p3.LastName} is {p3.Age} Years Old.");
            Console.WriteLine($"{p4.FirstName} {p4.LastName} is {p4.Age} Years Old.");
        }
    }
}