using System;
using System.Collections.Generic; 

namespace InheritancePolymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            // Animal a1 = new Animal("Rufus");
            // a1.PrintName();
            //a1.Name = "dufus";
            // Animal a2 = new Animal("lutus");
            //a2.PrintName();

            Warrior w = new Warrior();
            w.MeleeAttack();

            BattleMage bm = new BattleMage();
            bm.MagicAttack();

            Dog d = new Dog("Lady");
            d.PrintName();
            d.Speak();

            Cat c = new Cat("Treasure");
            c.PrintName();
            c.Speak();

            Animal[] animals = new Animal[2];
            //animals[0] = a1;
            animals[0] = d;
            animals[1] = c;
            foreach (Animal a in animals)
            {
                a.Speak();
            }
        }
    }

     public class fighter
    {
        string opponent;
        int maxHealth = 15; // declare maxHealth as int to hold total amount of health an oppoenet can have 
        int currentHealth = 10; // declare playerHealth as int to hold total amount of health for player
        int death = 0; // declare death as int that will determine if the player or enemy is dead 

        public void Fighter(string o)
        {
             opponent = o;
        }

        public void takingDamage()
        {
            Random rnd = new Random();
            int damage = rnd.Next(1, 9);
            int attack = currentHealth - damage;

            if (currentHealth == death)
            {
                deadFighter();
            }
          
        }

        public void deadFighter()
        {
            Console.WriteLine("The player has died - GameOver");
        }

        public void takingAction()
        {

        }
    }

    interface IFighter
    {
        void MeleeAttack();
    }

    interface IMAge
    {
        void MagicAttack();
    }

    public class BattleMage
    {
        public void MagicAttack()
        {
            Console.WriteLine("Used Magic ");
        }
    }

    public class Warrior : IFighter
    {
        public void MeleeAttack()
        {
            Console.WriteLine("Punch");
        }
        

    }
    abstract class Animal
    {
        public string name;


        public Animal(string n)
        {
            name = n;

        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public void PrintName()
        {
            Console.WriteLine("My name is " + name);
        }

        public virtual void Speak()
        {
            Console.WriteLine("Animal sound");
        }

    }

    class Dog : Animal
    {
        public Dog(string n) : base(n)
        {
            Name = n;
        }

        public override void Speak()
        {
            Console.WriteLine("WROOF");
        }


    }
    class Cat : Animal
    {
        public Cat(string n) : base(n)
        {
            Name = n;
        }

        public override void Speak()
        {
            Console.WriteLine("Meow");
        }
    }
}
