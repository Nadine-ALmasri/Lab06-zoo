using Lab06_zoo.classes_lab07;
using System;

namespace Lab06_zoo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Parrot p = new Parrot();
            p.Display();
            p.Move();
            p.Eat();
            p.Fly();
            Console.WriteLine("---------------------------------------------");

            Cat cat = new Cat { NumberOfLegs = 4 };
            cat.Display();
            cat.Move();
            cat.Eat();
            Console.WriteLine(cat.NumberOfLegs);
            Console.WriteLine("---------------------------------------------");
            Dog dog = new Dog { NumberOfLegs = 4 };
            dog.Display();
            dog.Move();
            dog.Eat();
            Console.WriteLine(dog.NumberOfLegs);
            Console.WriteLine("---------------------------------------------");
            Chicken chicken = new Chicken();
            chicken.Display();
            chicken.Move();
            chicken.Eat();
            chicken.Fly();
            Console.WriteLine("---------------------------------------------");
            Giraffe giraffe = new Giraffe { NumberOfLegs = 4 };
            giraffe.Display(); giraffe.Move(); giraffe.Eat();
            Console.WriteLine(giraffe.NumberOfLegs);
            Console.WriteLine("---------------------------------------------");
            Monkey monkey = new Monkey();
            Console.WriteLine("About Monkey");
            monkey.Move(); 
            monkey.Activity();
            monkey.family();
            monkey.Place();
            monkey.bodyCover();
            monkey.LivesInGroups();
            Console.WriteLine("---------------------------------------------");
            Shark shark = new Shark();
            Console.WriteLine("About Shark");
            shark.Activity();
            shark.family();
            shark.Place();
            shark.bodyCover();
            shark.LivesInGroups();
            Console.WriteLine("---------------------------------------------");
        }
    }
}