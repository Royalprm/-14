using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Упражнение_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Dog dog1 = new Dog("Собакен");
            dog1.ShowInfo();

           
            Cat cat1 = new Cat("Котяус");
            cat1.ShowInfo();

            
            Console.WriteLine("Press any key");
            Console.ReadKey();
        }
    }
    abstract class Animal
    {
        
        protected Animal(string name)
        {
            Name = name;
        }

        
        public abstract string Name { get; set; }

        
        public abstract void Say();
        public void ShowInfo()
        {
            Console.WriteLine($"Мое имя {Name}");
            this.Say();
        }
    }
    class Dog : Animal
    {
        // constructor
        public Dog(string name) : base(name) { }

        // fields with get / set options
        private string name;
        public override string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        // overrided method Say from base class
        public override void Say()
        {
            Console.WriteLine("Гав!");
        }
    }

    class Cat : Animal
    {
        // constructor
        public Cat(string name) : base(name) { }

        // fields with get / set options
        private string name;
        public override string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        // overrided method Say from base class
        public override void Say()
        {
            Console.WriteLine("Мяу!.");
        }
    }
}
