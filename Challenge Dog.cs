using System;

namespace Challenge_Dog
{
    class Challenge_Dog
    {
        //static void Main(string[] args)
        //{

    //Create an enum for gender
    public enum Gender { Male,Female};
    
    //Create a class called Dog
    class Dog
    {
        //The public properties for Dog
        private string name;
        private string owner;
        private int age;
        private Gender gender;
       
        //Creating the constructor and initializing the properties
        public Dog(string name,string owner,int age,Gender gender)
        {
            this.name = name;
            this.owner = owner;
            this.age = age;
            this.gender = gender;
        }
        //Creating the method called bark 
        public void Bark(int times)
        {
            for(int i = 0; i < times; i++)
            {
                Console.Write("Woof!");
            }
            Console.WriteLine();
        }
        //Creating the method called Get Tag
        public string GetTag()
        {
            string tag = "If lost, call "+owner+". ";
            if (gender == 0)
            {
                tag += "His name is " + name + " he is " + age.ToString();
            }
            else
            {
                tag += "Her name is " + name + " she is " + age.ToString();
            }
            if (age > 1)
            {
                tag += " years old.";
            }
            else
            {
                tag += " year old.";
            }
            return tag;
        }
    }
    class Program
    {
        //Creating the main function of the program
        static void Main(string[] args)
        {
            //Testing the instances 
            Dog puppy = new Dog("Orion", "Shawn", 1, Gender.Male); 
            puppy.Bark(3); 
            Console.WriteLine(puppy.GetTag()); 

            Dog myDog =new Dog("Lileu", "Dale", 4, Gender.Female); 
            myDog.Bark(1); 
            Console.WriteLine(myDog.GetTag()); 
        }
    }
}
        }

