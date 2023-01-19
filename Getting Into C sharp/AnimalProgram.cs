using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Getting_Into_C_sharp
{
    //TEST 
    public abstract class Animal
    {
        //private variables containing the different attributes of an animal
        private string Name;
        private int Age;
        private string Noise;
        private int Weight;

        public abstract void printInfo();
        public abstract void makeNoise();
        public abstract void ageUp();

        //this method is to take in user input and assigns it to the variables in the class
        public abstract void attributes(string nameInput, int ageInput, int weightInput);

        //getter and setter for the Name value
        public string name
        {
            get
            {
                return Name;
            }

            set
            {
                Name = value;
            }
        }

        //getter and setter for the age variable
        public int age
        {
            get
            {
                return Age;
            }

            set
            {
                Age = value;
            }
        }

        //getter and setter for the noise variable
        public string noise
        {
            get
            {
                return Noise;
            }

            set
            {
                Noise = value;
            }
        }

        //getter and setter for the weight variable
        public int weight
        {
            get
            {
                return Weight;
            }

            set
            {
                Weight = value;
            }
        }
    }

    public class Cat : Animal
    {
        public override void attributes(string nameInput, int ageInput, int weightInput) //if the name means type we dont need it
        {
            noise = "meow";
            name = nameInput;
            age = ageInput;
            weight = weightInput;
        }
        public override void printInfo()
        {
            Console.WriteLine("Species: Cat");
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Noise: " + noise);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Weight:  " + weight + " lbs");
            //Console.ReadKey();
        }
        public override void makeNoise()
        {
            Console.WriteLine(noise); //needs to use the variable
            //Console.ReadKey();
        }

        public override void ageUp()
        {
            Console.WriteLine(name + "'s age has been increased by one year");
            age = age + 1;
        }
    }

    public class Cassowary : Animal
    {
        public override void attributes(string nameInput, int ageInput, int weightInput) //if the name means type we dont need it
        {
            noise = "squawk";
            name = nameInput;
            age = ageInput;
            weight = weightInput;
        }
        public override void printInfo()
        {
            Console.WriteLine("Species: Cassowary");
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Noise: " + noise);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Weight:  " + weight + " lbs");
            //Console.ReadKey();
        }
        public override void makeNoise()
        {
            Console.WriteLine(noise); //needs to use the variable
            //Console.ReadKey();
        }

        public override void ageUp()
        {
            Console.WriteLine(name + "'s age has been increased by one year");
            age = age + 1;
        }
    }

    public class Crab : Animal
    {
        public override void attributes(string nameInput, int ageInput, int weightInput)
        {
            noise = "money money money";
            name = nameInput;
            age = ageInput;
            weight = weightInput;
        }
        public override void printInfo()
        {
            Console.WriteLine("Species: Crab");
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Noise: " + noise);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Weight:  " + weight + " lbs");
            //Console.ReadKey();
        }
        public override void makeNoise()
        {
            Console.WriteLine(noise); //needs to use the variable
            //Console.ReadKey();
        }

        public override void ageUp()
        {
            Console.WriteLine(name + "'s age has been increased by one year");
            age = age + 1;
        }
    }

    class World 
    {
        //this line declares the animal list
        List<Animal> animalList = new List<Animal>();

        //this method adds a new animal to the list
        static void newEntry(string choice, List<Animal> animalList, Animal newAnimal)
        {
            //these variables will store in the user inputted attribute values
            string Name;
            string Age;
            string Weight;

            //if the number is 1 then a Cat object is created
            if (choice == "1")
            {
                newAnimal = new Cat();
            }

            //if the number is 2 then a Cassowary object is created
            else if (choice == "2")
            {
                newAnimal = new Cassowary();
            }

            //if the number is 3 then a Crab object is created
            else if (choice == "3")
            {
                newAnimal = new Crab();
            }

            //the function exits if the number is something other than 1, 2, or 3
            else
            {
                return;
            }

            //the following lines prompt the user to enter information about the animal
            Console.Write("Enter the name of your animal: ");
            Name = Console.ReadLine();
            Console.Write("Enter the age of your animal: ");
            Age = Console.ReadLine();
            Console.Write("Enter the weight of your animal in pounds: ");
            Weight = Console.ReadLine();

            //we need to call the attribute method to send the user inputted information to the 
            //class. The Age and Weight values must be converted from strings to integers. 
            newAnimal.attributes(Name, Convert.ToInt32(Age), Convert.ToInt32(Weight));

            //this line adds the animal object to the list
            animalList.Add(newAnimal);

            //prints a message letting the user know that the process was completed
            Console.WriteLine(Name + " has been added successfully");
        }

        static void Main(string[] args)
        {
            //declare the existance of a world object so we can use the methods
            World p = new World();
            //this variable stores the user's choice at the menu
            string userInput;

            //the following lines list the choices that are avaliable to the user
            Console.WriteLine("Welcome to the Animal List program!");
            Console.WriteLine("1. Print the list");
            Console.WriteLine("2. Print the info of an animal in the list");
            Console.WriteLine("3. Print the noise of an animal in the list");
            Console.WriteLine("4. Increase the age of an animal in the list");
            Console.WriteLine("5. Add a new animal to the list");
            Console.WriteLine("6. Exit");
            Console.WriteLine();

            //these lines prompt the user for their choice and store the choice
            Console.Write("Enter the number of the function you would like to perform: ");
            userInput = Console.ReadLine();

            //if the user enters the number 6, the loop exits and the program closes
            while (userInput != "6")
            {
                //if the user selects 1, the entire list and all info within is printed
                if (userInput == "1")
                {
                    //loops through the list and prints the info
                    foreach (Animal a in p.animalList)
                    {
                        //prints the info of the current animal
                        a.printInfo();
                    }
                }

                if (userInput == "2")
                {
                    string choice2;

                    Console.Write("Enter the name of the Animal: ");
                    choice2 = Console.ReadLine();

                    //searches the list for the name
                    Animal aObject = p.animalList.Find(n => n.name == choice2);

                    //prints the object information, needs the if statement incase the object isn't found
                    if (aObject != null)
                    {
                        Console.WriteLine();
                        aObject.printInfo();
                    }

                }

                if (userInput == "3")
                {
                    string choice;

                    Console.Write("Enter the name of the Animal: ");
                    choice = Console.ReadLine();

                    //searches the list for the name
                    Animal aObject = p.animalList.Find(n => n.name == choice);

                    //prints the object information, needs the if statement incase the object isn't found
                    if (aObject != null)
                    {
                        Console.WriteLine();
                        aObject.makeNoise();
                    }

                }

                if (userInput == "4")
                {
                    string choice;

                    Console.Write("Enter the name of the Animal: ");
                    choice = Console.ReadLine();

                    //searches the list for the name
                    Animal aObject = p.animalList.Find(n => n.name == choice);

                    //prints the object information, needs the if statement incase the object isn't found
                    if (aObject != null)
                    {
                        Console.WriteLine();
                        aObject.ageUp();
                    }

                }

                //if the user inputs the number 5, then this allows them to pick an Animal to add
                if (userInput == "5")
                {
                    string choice;
                    Console.WriteLine("Choices: 1. Cat | 2. Cassowary | 3. Crab");
                    Console.WriteLine();
                    Console.Write("Enter the number of the animal you would like to add: ");
                    choice = Console.ReadLine();
                    Console.WriteLine();

                    //the user's choice must be either 1 2 or 3 because there are no other animal options
                    if ((choice != "1") && (choice != "2") && (choice != "3"))
                    {
                        //if the user inputs an incorrect value they are given a warning
                        Console.WriteLine("Invalid Input");
                    }
                    else
                    {
                        //since the Animal object is abstract we need to set it to null
                        Animal a = null;
                        //this should call the new animal method
                        newEntry(choice, p.animalList, a);

                    }

                }

                //these lines prompt the user for another choice
                Console.WriteLine();
                Console.Write("Enter another number of your choice: ");
                userInput = Console.ReadLine();
                Console.WriteLine();

            }

        }
    }
}

