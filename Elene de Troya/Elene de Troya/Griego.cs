using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elene_de_Troya
{
    class Griego
    {
        private string name;
        private int age;
        private int strength;
        private bool injured;
        private bool dead;


        //Crear un constructor para esta clase que reciba el nombre, edad y fuerza del Griego
        public Griego(string name, int age, int strength)
        {
            this.name = name;
            if (VerifyAge())
            {
                Console.WriteLine(this.age);
            }
            else
            {
                Console.WriteLine(25);
            }

            if (VerifyStrength())
            {
                Console.WriteLine(this.strength);
            }
            else
            {
                Console.WriteLine(5);
            }
            this.injured = true;
            this.dead = false;
        }

        //Crea un segundo constructor sin parámetros que ponga como nombre “GriegoX”, edad:20 y fuerza:8
        public Griego()
        {
            this.name = "GriegoX";
            this.age = 20;
            this.strength = 8;
            this.injured = true;
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

        public void GiveInInJ()
        {
            if (dead)
            {
                Console.WriteLine("DEAD.");
            }

        }

        public void WithdrawBoolInj()
        {
            if (dead)
            {
                Console.WriteLine("INJURED.");
            }

        }
        //boolean Verify Age (int age): that returns true if the age is between 15 and 60 (both inclusive), false otherwise.
        public bool VerifyAge()
        {
            if (15 <= this.age || this.age <= 60)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //boolean ComprobarFuerza(int f) returns true if the strength is between 1 and 10 (both inclusive), false otherwise.
        public bool VerifyStrength()
        {
            if (1 <= this.strength || this.strength <= 10)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool GiveIn()
        {
            if(injured && dead ==false)
            {
                Console.WriteLine("You can give up...");
            }
            return true;
        }
    }

}
