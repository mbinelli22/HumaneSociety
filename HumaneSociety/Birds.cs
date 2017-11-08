using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    class Birds : Animal
    {
        //member variables

        //constructor
        public Birds(string Name, string Breed, string Gender, int Age, int Weight, int RoomNumber, bool VacinationStatus, double FoodAmount, bool AdoptionStatus)
        {
            name = Name;
            type = "Bird";
            breed = Breed;
            gender = Gender;
            age = Age;
            weight = Weight;
            roomNumber = RoomNumber;
            vacinationStatus = VacinationStatus;
            foodType = "Bird Food";
            foodAmount = FoodAmount;
            adoptionStatus = AdoptionStatus;
        }

        //member methods
    }
}
