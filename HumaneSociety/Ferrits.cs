using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    class Ferrits : Animal
    {
        //member variables

        //constructor
        public Ferrits(string Name, string Gender, int Age, int Weight, int RoomNumber, bool VacinationStatus, double FoodAmount, bool AdoptionStatus)
        {
            name = Name;
            type = "Ferrit";
            breed = "Ferrit";
            gender = Gender;
            age = Age;
            weight = Weight;
            roomNumber = RoomNumber;
            vacinationStatus = VacinationStatus;
            foodType = "Ferrit Food";
            foodAmount = FoodAmount;
            adoptionStatus = AdoptionStatus;
        }

        //member methods


    }
}
