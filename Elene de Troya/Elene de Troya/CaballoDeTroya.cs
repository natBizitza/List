using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elene_de_Troya
{
    class CaballoDeTroya
    {
        //        capacidad, representa el número de guerreros griegos que puede haber dentro del caballo.
        //            No se podrá cambiar una vez le hemos dado valor.
        //ocupacion, representa el número actual de griegos en el caballo.
        //ocupantes, lista de objetos de la clase Guerrero.
        private int capacity;
        private int ocupation;
        private List<Griego> ocupants;

        //Create a constructor for the class Horse with space for as many warriors as you enter 
        //the parameter that is passed to that constructor. 

        public CaballoDeTroya(int ocupation)
        {
            this.capacity = capacity;
            this.ocupation = ocupation;
            List<Griego> ocupants = new List<Griego>();
        }

        //Get & Set()
        public int GetCapacity()
        {
            return this.capacity;
        }
        public void SetCapacity(int capacity)
        {
            this.capacity = capacity;
        }
        public int GetOcupation()
        {
            return this.ocupation;
        }
        public void SetOcupation(int ocupation)
        {
            this.ocupation = ocupation;
        }

        //Create a method Search(name) search by name a warrior within the list of occupants and return 
        //the position or -1 if it is not.

        public int SearchName(string name)
        {
            // this value is by default and will changein case in passes the foreach loop
            int pos = -1;
            foreach(Griego x in ocupants)
            {
                if(x.GetName()==name)
                {
                    int index = ocupants.IndexOf(x);
                    return index;
                } 
            }
            return pos;
        }
        // Create a method MostrarGuerreroPosicion(pos) If the position is valid, the display 
        //shows the data of the warrior of position pos. And if it does not indicate that it is not possible.
        public string ShowGriegoPos(int pos)
        {
            string dataOfGriego = "Impossible to show.";

            foreach(Griego x in ocupants)
            {
               int index = ocupants.IndexOf(x);

                if(index ==pos)
                {
                    string name1 = x.GetName();
                    return name1;
                }
            }
            return dataOfGriego;
        }
        //Create a method MontarseEnCaballo(Greek) that receives as a 
        //parameter a Greek and the goal in the list of occupants (if there is room). 

        public void AddGriegoInHorse(Griego griego)
        {
            if(capacity>ocupation)
            {
                ocupants.Add(griego);
                Console.WriteLine("Greek " + griego + " in the horse now!");
            }
        }
       //Creates the method MostarCaballo() that displays on the screen the information concerning:
       //-Capacity, occupation and list of occupants with their data
       public string ShowHorse()
        {
            string result = " ";
            // it's important to show that capacity '0' in case it's zero
            result += "Capacity: ";
            result += this.GetCapacity() + " ";

            if (this.GetOcupation() > 0)
            {
                result += this.GetOcupation() + " ";
            }
            if (ocupants.Count > 0)
            {
                result += "\nList of occupants:\n";
                foreach (Griego x in ocupants)
                {
                    result += x.GetName() + " ";
                }
            }
            return result;
        }
    }
}
