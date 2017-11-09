using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    abstract class Animal
    {
        //member variables
        public string name;
        public string type;
        public string breed;
        public string gender;
        public int age;
        public int weight;
        public int roomNumber;
        public bool vacinationStatus;
        public string foodType;
        public double foodAmount;
        public bool adoptionStatus;

        //constructor
        public Animal()
        {

        }

        public abstract string AnimalArray();

    }
}
