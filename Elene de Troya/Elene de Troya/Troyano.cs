using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elene_de_Troya
{
    class Troyano
    {
        private string name;
        private int age;
        private int strength;
        private bool injured;
        private bool dead;

        //Create a constructor for the class, Trojan: you will get values for all the attributes except 
        //the wounded and dead, which obviously will be false. You need to check that the values given are 
        //valid and otherwise put as age 25 and as a force 5.
        public Troyano(string name, int age, int strength, bool injured, bool dead)
        {
            this.name = name;

            if(VerifyAge(age))
            {
                Console.WriteLine(this.age);
            }
            else
            {
                Console.WriteLine(25);
            }

            if(VerifyStrength(strength))
            {
                Console.WriteLine(this.strength);
            }
            else
            {
                Console.WriteLine(5);
            }
            this.injured = false;
            this.dead = false;
        }

        //Crea un segundo constructor sin parámetros que ponga como nombre “TroyanoX”, edad 18 y fuerza 10.
        public Troyano()
        {
            this.name = "TroyanoX";
            this.age = 18;
            this.strength = 10;
            this.injured = false;
            this.dead = false;
        }

        // Get() & Set() methods
        public string GetName()
        {
            return this.name;
        }
        public void SetName(string name)
        {
            this.name = name;
        }

        public int GetAge()
        {
            return this.age;
        }
        public void SetAge(int age)
        {
            this.age = age;
        }

        public int GetStrength()
        {
            return this.strength;
        }
        public void SetStrength(int strength)
        {
            this.strength = strength;
        }

        public bool GetInjured()
        {
            return this.injured;
        }
        public void SetInjured(bool injured)
        {
            this.injured = injured;
        }

        public bool GetDead()
        {
            return this.dead;
        }
        public void SetDead(bool dead)
        {
            this.dead = dead;
        }

        //public void giveInDead()
        //{
        //    if(dead)
        //    {
        //        Console.WriteLine("DEAD.");
        //    }

        //}
        //TODO: change the method below
        public bool GiveInInj()
        {
            if (injured)
            {
                return true;
                
            }
            return false;

        }

        //boolean Verify Age (int age): that returns true if the age is between 15 and 60 (both inclusive), false otherwise.
         public bool VerifyAge(int ag)
        {
            if(15 <= this.age || this.age <= 60 )
            {
                return true;
            }
                return false;
        }

        //boolean ComprobarFuerza(int f) returns true if the strength is between 1 and 10 (both inclusive), false otherwise.
        public bool VerifyStrength(int strength)
        {
            if (1 <= this.strength || this.strength <= 10)
            {
                return true;
            }
                return false;
        }
        //TODO: add one more method
        public bool GiveIn()
        {
            Console.WriteLine("We never give up!");
            return false;
        }

    }
}
